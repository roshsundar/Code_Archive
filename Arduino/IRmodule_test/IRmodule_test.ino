int input = 0;
void setup() {
  Serial.begin(9600);
}

void loop() {
  input = digitalRead(10);
  Serial.println(input);
  delay(1000);
}
