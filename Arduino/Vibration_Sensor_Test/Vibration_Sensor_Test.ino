int inputPin = 2;               // choose the input pin (for Vibration sensor)
int val = 0;                    // variable for reading the pin status

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
    Serial.println("Motion detected!");
  } 
}
