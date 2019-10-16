#include <SoftwareSerial.h>
#include <SerialCommand.h>

SerialCommand sCmd;
void setup() {
  Serial.begin(9600);
}

void loop() {
  Serial.println("Hey");
  delay(1200);
}
