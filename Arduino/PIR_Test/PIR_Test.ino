int inputPin = 2;               // choose the input pin (for PIR sensor)
int val = 0;                    // variable for reading the pin status
int pirState = LOW;

void setup() 
{
  pinMode(inputPin, INPUT);     // declare sensor as input
 
  Serial.begin(9600);
}
 
void loop()
{
  val = digitalRead(inputPin);  // read input value
  if (val == HIGH) // check if the input is HIGH
  {            
    if (pirState == LOW) 
    {
      // we have just turned on
      Serial.println("Motion detected!");
      // We only want to print on the output change, not state
      pirState = HIGH;
    }
  } 
  else 
  {
    if (pirState == HIGH)
    {
      // we have just turned of
      Serial.println("Motion ended!");
      // We only want to print on the output change, not state
      pirState = LOW;
    }
  }
}
