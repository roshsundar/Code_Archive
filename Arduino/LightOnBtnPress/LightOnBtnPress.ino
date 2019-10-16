const int buttonPin = 2;  // Fill pin vars with appropriate pins
const int ledPin =  13; 

int buttonState = 0;
int delayMilliecs = 10000;

void setup() 
{
  pinMode(ledPin, OUTPUT);
  pinMode(buttonPin, INPUT);
}

void loop() 
{
  buttonState = digitalRead(buttonPin);
  
  if (buttonState == HIGH)
  {
    digitalWrite(ledPin, HIGH);
    delay(delayMilliecs);
    digitalWrite(ledPin, LOW);
  }
}
