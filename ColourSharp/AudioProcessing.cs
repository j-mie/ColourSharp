using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SFML.Graphics;
using SFML.Window;
using Un4seen.Bass;

namespace Aero_Visualizer
{
    class AudioProcessing
    {
         private float GetAverage(int startRange, int endRange, float[] fftInfo, float mutiplyer)
        {
            float average = 0;
            for (int i = startRange; i <= endRange; i++)
            {
                average += fftInfo[i];
            }
            return average*mutiplyer;
        }

        private VertexArray[] VertexArrayGenerator(float[] fft, int panelHeight)
        {
            var a11 = new VertexArray(PrimitiveType.LinesStrip, 2048);
            var a12 = new VertexArray(PrimitiveType.LinesStrip, 2048);

            int peak = 0;
            for (int i = 0; i < fft.Length; i++)
            {
                a11[(uint) i] = new Vertex(new Vector2f(i, panelHeight - (fft[(uint) i]*panelHeight*20)),
                    SFML.Graphics.Color.Green);
                try
                {
                    if (fft[i] > fft[i - 1])
                    {
                        peak = i;
                    }
                }
                catch
                {
                }
                a12[(uint) i] = new Vertex(new Vector2f(peak, panelHeight - (fft[peak]*panelHeight*20)),
                    SFML.Graphics.Color.White);
            }
            var array = new VertexArray[2];
            array[0] = a11;
            array[1] = a12;

            return array;
        }

        public void Think(int stream, Panel sfmlPanel)
        {
            var fft = new float[2048];
            Bass.BASS_ChannelGetData(stream, fft, (int)BASSData.BASS_DATA_FFT4096);

            //for (int v = 0; v < fft.Length; v++)
            //{
            //    fft[v] = fft[v] * trackBar1.Value;
            //}

            var bassaverage = GetAverage((int)json.config.bass.start, (int)json.config.bass.end, fft,
                    2.6f);
            var snareaverage = GetAverage((int)json.config.snare.start, (int)json.config.snare.end, fft,
    2.6f);
            var talkaverage = GetAverage((int)json.config.talk.start, (int)json.config.talk.end, fft,
                2.6f);

            window.Clear();

            VertexArray[] vertexArrays = VertexArrayGenerator(fft, sfmlPanel.Height);

            text_Red.Position = new Vector2f(40, 40);
            text_Blue.Position = new Vector2f(40, 120);
            text_Green.Position = new Vector2f(40, 200);

            window.Draw(text_Red);
            window.Draw(text_Green);
            window.Draw(text_Blue);
            window.Draw(vertexArrays[0]);
            window.Draw(vertexArrays[1]);
            window.Display();

            int BR, BG, BB, SR, SG, SB, TR, TG, TB;

            Color.HsvToRgb((int)json.config.bass.hue, 1, bassaverage, out BR, out BG, out BB); //R
            Color.HsvToRgb((int)json.config.snare.hue, 1, snareaverage, out SR, out SG, out SB); //G
            Color.HsvToRgb((int)json.config.talk.hue, 1, talkaverage, out TR, out TG, out TB); //B

            text_Red.DisplayedString = String.Format("Red: {0}", BR);
            text_Green.DisplayedString = String.Format("Green: {0}", SG);
            text_Blue.DisplayedString = String.Format("Blue: {0}", TB);

            colorOutput.BackColor = System.Drawing.Color.FromArgb(255, BR, SG, TB);
            Dwm.SetDwmColor(System.Drawing.Color.FromArgb(255, BR, SG, TB));

            try
            {
                SP.Write("R");
                SP.Write(new[] { (byte)BR }, 0, 1);
                SP.Write("G");
                SP.Write(new[] { (byte)SG }, 0, 1);
                SP.Write("B");
                SP.Write(new[] { (byte)TB }, 0, 1);
            }
            catch
            {
                if (!comError)
                {
                    comError = true;
                    Console.WriteLine("No COM Port set or can't comunicate with the com port");
                }
            }
        }
    }
}
