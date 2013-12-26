byte incomingByte = 0;	
int r = 9;
int g = 11;
int b = 10;
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
		incomingByte = Serial.read();
                numbertrans = incomingByte;
                if (part == 0) {datar = numbertrans;} 
                if (part == 1) {datag = numbertrans;}                
                if (part == 2) {datab = numbertrans;}
                  part++;
                //Serial.println(numbertrans);     
                if (part == 3) {       
                      analogWrite(9, datar); 
                      analogWrite(10, datag); 
                      analogWrite(11, datab); 
                      part = 0;}


	}

}
