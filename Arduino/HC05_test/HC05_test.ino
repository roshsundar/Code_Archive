String recieved;

void setup() {
  Serial.begin(9600);
}

void loop() {
  if(Serial.available() > 0)
  {
    recieved = Serial.readString();
    if (recieved == "Hello")
    {
      Serial.println("hey"); 
    }
  }
}
