int read2 = 0;
void setup() {
  Serial.begin(9600);
}

void loop() {
  read2 = analogRead(2); // takes an analog pin argument // returns a value between 0 and 1023
  Serial.println(read2);
  delay(500);
}
