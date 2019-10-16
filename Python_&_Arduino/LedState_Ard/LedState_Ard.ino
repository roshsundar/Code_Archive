/* The purpose of this program is to make the onboard led blink on and off, print the state to the serial port, and have python read it */

int ledPin = 13;

void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
}

void loop() {
  digitalWrite(ledPin, HIGH); // Turn LED on
  Serial.println("the led is on"); // Print to the serial port an indicator to be read by python that the led is on
  
  delay(1000); // In milliseconds
  
  digitalWrite(ledPin, LOW); // Turn LED off
  Serial.println("the led is off"); // Print to the serial port an indicator to be read by python that the led is off
  
  delay(1000); // In milliseconds
}
