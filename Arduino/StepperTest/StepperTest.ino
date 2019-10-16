// The purpose of this program is to test stepper motors
#include <CustomStepper.h>
CustomStepper motor1(31,33,35,37);

void setup() {
  motor1.setRPM(12); // Set the RPM of stepper
  motor1.setSPR(4096); // Set full step, half step, etc. // 4096 is half step     
  motor1.setDirection(CW); // Direction ( CW or CCW or STOP )
  motor1.rotate(); // Amnt of degree rotation
}

void loop() {
  motor1.run(); // Run motor, must run continuously in a loop for it to work
}

// max speed is 1250 steps/sec for 28byj-48 with ULN003 driver board
