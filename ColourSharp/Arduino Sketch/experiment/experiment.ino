void setup() {
  Serial.begin(9600); 
}

void loop() {
  if (Serial.available() > 0) { 
    String inc = Serial.readString();
    int data[3];
    int numArgs = 0;
    
    int beginIdx = 0;
    int idx = inc.indexOf(",");
    
    String arg;
    char charBuffer[16];
    
    while (idx != -1)
    {
        arg = inc.substring(beginIdx, idx);
        arg.toCharArray(charBuffer, 16);
    
        // add error handling for atoi:
        data[numArgs++] = atoi(charBuffer);
        beginIdx = idx + 1;
        idx = inc.indexOf(",", beginIdx);
    }
    
    data[numArgs++] = inc.substring(beginIdx).toInt();
    Serial.println(data[0]);
    Serial.println(data[1]);
    Serial.println(data[2]);
    
    analogWrite(9, data[0]); 
    analogWrite(10, data[1]); 
    analogWrite(11, data[2]); 

  }
}


