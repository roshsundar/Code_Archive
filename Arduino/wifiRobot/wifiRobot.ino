#include <Servo.h>

Servo driver;
Servo control;

driverPin = 0; // what pin the cont.rot.servo will be on
contolPin = 0; // what pin the servo will be on

String comm; // command recieved from the serial port
String prev_comm; // this is the previous command issued

void setup() {
  Serial.begin(9600);
  
  driver.attach(driverPin);
  control.attach(controlPin);

  while (Serial.available() == 0) { } 

  // processing data will go here

  prev_command = ;// this will set the command sent as a previous one to be run unitl new command is revieved
}

void loop() {
  while (Serial.available() == 0)
  {
    driver.write(prev_command);
  }

}
