
using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using SFML.Graphics;
using SFML.Window;
using Un4seen.Bass;
using Un4seen.BassWasapi;
using Image = System.Drawing.Image;



namespace Aero_Visualizer
{
    public partial class MainForm : Form
    {
        public static dynamic json = JsonConvert.DeserializeObject(File.ReadAllText("config.json"));

        private readonly HSLColor Color = new HSLColor(); //Used for storing the current color
        private readonly IniFile ini = new IniFile(Directory.GetCurrentDirectory() + @"\setup.ini");
        private readonly FileSystemWatcher watcher = new FileSystemWatcher();
        private readonly RenderWindow window;
        private WinAPI.DWM_COLORIZATION_PARAMS Backup; //Var for storing their current color scheme
        private int Device; //Device to play from

        private Text text_Red = new Text("RGB", new Font("OxygenMono-Regular.ttf"));
        private Text text_Green = new Text("RGB", new Font("OxygenMono-Regular.ttf"));
        private Text text_Blue = new Text("RGB", new Font("OxygenMono-Regular.ttf"));

        //Create the WASAPI vars 
        private BassWasapiHandler _wasapi; //Speedy thing goes in
        private BassWasapiHandler _wasapiOutput; //Speedy thing comes out

        private Boolean comError;
        private int stream = -1; //The streamID for BASS

        public MainForm()
        {
            
            InitializeComponent();
            SP.Close();
            watcher.Path = Directory.GetCurrentDirectory();
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Only watch json config.
            watcher.Filter = "config.json";
            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            window = new RenderWindow(SFMLPanel.Handle);
            try
            {
                Device = Convert.ToInt16(ini.IniReadValue("recent_device", "DeviceNumber"));
            }
            catch (Exception)
            {
                Device = -1;
            }

            //Try Applying general settings
            try
            {
                if (ini.IniReadValue("GeneralSettings", "MintoTray") == "True")
                {
                    Check_MintoTray.Checked = true;
                }

                SP.PortName = ini.IniReadValue("GeneralSettings", "COM");
            }
            catch (Exception)
            {
                try
                {
                    SP.PortName = ini.IniReadValue("GeneralSettings", "COM");
                }
                catch
                {
                }
                Check_MintoTray.Checked = false;
            }
            Console.WriteLine("COM PORT: " + ini.IniReadValue("GeneralSettings", "COM"));


            //serialPort1.PortName = "COM3"

            SP.BaudRate = 115200;
            try
            {
                SP.Open();
            }

            catch
            {
                if (!comError)
                {
                    comError = true;
                    Console.WriteLine("No COM Port set or can't comunicate with the com port");
                }
            }

            //If you see this, plz don't take my kredz
            //This is so you don't see the dumb HERPADERP BASS IS STARTING spash screen
            BassNet.Registration("swkauker@yahoo.com", "2X2832371834322");
            //Start base itself
            //Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

            //Populate the possible devices list
            var info = new BASS_WASAPI_DEVICEINFO();
            var Devices = new int[BassWasapi.BASS_WASAPI_GetDeviceCount()]; //List of devices

            for (int n = 0; BassWasapi.BASS_WASAPI_GetDeviceInfo(n, info); n++)
            {
                if (info.SupportsRecording && info.IsEnabled)
                {
                    DeviceList.Items.Add(info.ToString());
                    Devices[n] = n;
                    if (n == Device)
                    {
                        DeviceList.SelectedItem = info.ToString();
                    }
                }
            }

            //DeviceList.SelectedIndex = 2;

            if (StartBass()) //No errors and a device was properly chosen
            {
                TrayContextEnable.Enabled = true;
            }
        }

        private bool StartBass()
        {
            try
            {
                //Start Bass and BassWASAPI
                Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                BassWasapi.BASS_WASAPI_Init(0, 44100, 2, BASSWASAPIInit.BASS_WASAPI_AUTOFORMAT, 0f, 0f, null,
                    IntPtr.Zero);
            }
            catch (Exception exc)
            {
                MessageBox.Show("BASS Failed to Init. \n " + exc);
            }

            // assign WASAPI input and outpt in shared-mode
            if (Device > 0)
            {
                try
                {
                    _wasapi = new BassWasapiHandler(Device, false, 44100, 2, 0f, 0f); //Device
                    _wasapiOutput = new BassWasapiHandler(Device, false, 48000, 2, 0f, 0f);

                    // init and start WASAPI
                    _wasapi.Init();
                    if (_wasapi.DeviceMute)
                        _wasapi.DeviceMute = false;
                    _wasapi.Start();

                    // setup a full-duplex stream
                    _wasapi.SetFullDuplex(0, BASSFlag.BASS_STREAM_DECODE, false);

                    stream = _wasapi.OutputChannel;
                    // and assign it to an output
                    _wasapiOutput.AddOutputSource(stream, BASSFlag.BASS_DEFAULT);

                    //Start the output stream
                    _wasapiOutput.Init();
                    _wasapiOutput.Start();

                    FFTThink.Enabled = true;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR STARTING WASAPI I/O: " + ex +
                                    "\n \nThis is usually due to an incorrect device being used, settings have been reset.");
                    ini.IniWriteValue("recent_device", "DeviceNumber", "-1");

                    Device = -1;
                    MessageBox.Show("OMG: Starting up abnormally.");

                    return false;
                }
            }
            MessageBox.Show("Please choose an output device in device settings before starting.");
            return false;
        }

        private bool StopBass()
        {
            FFTThink.Enabled = false;
            _wasapi.RemoveFullDuplex();
            _wasapi.Stop();
            _wasapiOutput.Stop();

            Bass.BASS_SetDevice(Device);

            _wasapi = null;
            _wasapiOutput = null;

            if (!Bass.BASS_Free() || !BassWasapi.FreeMe()) return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPI.DWM_COLORIZATION_PARAMS Temp;
            //Store their Original color settings, so they don't get angry!
            WinAPI.DwmGetColorizationParameters(out Backup);

            Temp.Color1 = Backup.Color1;
            Temp.Color2 = 2147483647;
            Temp.Intensity = Backup.Intensity;
            Temp.Unknown1 = Backup.Unknown1;
            Temp.Unknown2 = Backup.Unknown2;
            Temp.Unknown3 = Backup.Unknown3;
            Temp.Opaque = Backup.Opaque;
            WinAPI.DwmSetColorizationParameters(ref Temp, 4);

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += OnApplicationExit;
        }

        //Constantly get the current FFT data to update the colorization with

       

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //WinAPI.DwmSetColorizationParameters(ref Backup, 3);
            Dwm.SetDwmColor(System.Drawing.Color.FromArgb((int) Backup.Color1));

            Backup.Color2 = 0;
            WinAPI.DwmSetColorizationParameters(ref Backup, 4);

            ini.IniWriteValue("GeneralSettings", "MintoTray", Check_MintoTray.Checked.ToString());
            try
            {
                ini.IniWriteValue("GeneralSettings", "COM", comboBox1.SelectedItem.ToString());
            }
            catch
            {
                Console.WriteLine("Nothing in COM Port Selector");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine("Changed COM Port");
            Application.Restart();
        }

        private void ChangeDevice(object sender, EventArgs e)
        {
            var Selection = (ComboBox) sender;

            if (stream != -1) //Bass is started already
            {
                var info = new BASS_WASAPI_DEVICEINFO();
                bool Restart = false;
                for (int n = 0; BassWasapi.BASS_WASAPI_GetDeviceInfo(n, info); n++)
                {
                    if (info.ToString() == Selection.SelectedItem.ToString())
                    {
                        Device = n;

                        ini.IniWriteValue("recent_device", "DeviceNumber", n.ToString());
                        Restart = true;
                    }
                }
                if (Restart) Application.Restart();

                /*
                if (StartBass())//RE. START. EVERYTHING.
                {
                    PlayButton.Enabled = true;
                    TrayContextEnable.Enabled = true;

                }
                 * */
            }
            else //Only do this if bass hasn't started yet.
            {
                // Debug1.Text = Selection.SelectedItem.ToString();
                var info = new BASS_WASAPI_DEVICEINFO();

                for (int n = 0; BassWasapi.BASS_WASAPI_GetDeviceInfo(n, info); n++)
                {
                    if (info.ToString() == Selection.SelectedItem.ToString())
                    {
                        Device = n;
                        ini.IniWriteValue("recent_device", "DeviceNumber", n.ToString());
                        Application.Restart();
                    }
                }
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TrayContextRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            window.Size = new Vector2u((uint) SFMLPanel.Size.Width, (uint) SFMLPanel.Size.Height);

            if (FormWindowState.Minimized == WindowState && Check_MintoTray.Checked)
                Hide();
        }

        private void TrayContextClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(20);
            try
            {
                json = JsonConvert.DeserializeObject(File.ReadAllText("config.json"));
                Console.WriteLine(e.ChangeType.ToString());
            }
            catch (Exception ex)
            {
            }
        }
    }
}