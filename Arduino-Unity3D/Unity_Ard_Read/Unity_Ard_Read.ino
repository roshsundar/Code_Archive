#include <SoftwareSerial.h>
#include <SerialCommand.h>

SerialCommand sCmd;

void setup() {
  Serial.begin(9600);
  while(!Serial);

  sCmd.addCommand("PING", pingHandler);
  pinMode(13, OUTPUT);
}

void loop() {
  if(Serial.available() > 0)
  {
    sCmd.readSerial();
  }
}

// Recieve Function
void pingHandler(const char *command)
{
  digitalWrite(13, HIGH);
}

