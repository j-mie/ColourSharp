byte incomingByte = 0;
int datar = 0;
int datag = 0;
int datab = 0;
int part = 0;
byte numbertrans = 0;

void setup() {
  Serial.begin(9600); 
}

void loop() {
  if (Serial.available() > 0) { 
    numbertrans = Serial.read();
    
    if (part == 0)
      datar = numbertrans;
    if (part == 1)
      datag = numbertrans;
    if (part == 2)
      datab = numbertrans;

    part++;
  //Serial.println(numbertrans);     
    if (part == 3) {       
      analogWrite(9, datar); // Pin 9 Needs to be the Red LED
      analogWrite(10, datag); // Pin 10 Needs to be the Green LED
      analogWrite(11, datab); // Pin 11 Needs to be the Blue LED
      part = 0;
    }
  }
}
