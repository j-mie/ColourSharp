void setup()
{
  Serial.begin(115200);
  pinMode(9, OUTPUT); // red
  pinMode(10, OUTPUT); // green
  pinMode(11, OUTPUT); // blue
}
 
void loop()
{
  switch(ReadSer())
  {
  case 'R':
    analogWrite(9, ReadSer());
    break;
  case 'G':
    analogWrite(10, ReadSer());
    break;
  case 'B':
    analogWrite(11, ReadSer());
    break;
  }
}

int ReadSer()
{
  while (Serial.available()<=0) {
  }
  return Serial.read();
}
