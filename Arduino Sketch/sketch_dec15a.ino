int part = 0;
byte numbertrans = 0;

void setup() {
  Serial.begin(9600); 
}

void loop() {
  if (Serial.available() > 0) { 
    numbertrans = Serial.read();

    if (part == 0)
      analogWrite(9, numbertrans); // Pin 9 Needs to be the Red LED
    if (part == 1)
      analogWrite(10, numbertrans); // Pin 10 Needs to be the Green LED
    if (part == 2)
      analogWrite(11, numbertrans); // Pin 11 Needs to be the Blue LED

    part++;     
    if (part == 3)
      part = 0;
  }
}
