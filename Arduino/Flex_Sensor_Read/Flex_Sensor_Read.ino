int ReadPin = 0; // Will read on analog pin 0

int flexval;

void setup() {
  Serial.begin(9600);
}

void loop() {
  flexval = abs(analogRead(ReadPin)-542);

  Serial.println(flexval);
  delay(100);
}
