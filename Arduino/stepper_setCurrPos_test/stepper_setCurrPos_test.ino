#include <AccelStepper.h>
#define HALFSTEP 8

int Pin1 = 35;      // Blue   - 28BYJ48 pin 1
int Pin2 = 37;      // Pink   - 28BYJ48 pin 2
int Pin3 = 39;     // Yellow - 28BYJ48 pin 3
int Pin4 = 41;     // Orange - 28BYJ48 pin 4

AccelStepper stepper(HALFSTEP, Pin1, Pin3, Pin2, Pin4);

void setup() {
  stepper.setMaxSpeed(1000);
  stepper.setSpeed(512);
  stepper.setAcceleration(400);

  Serial.begin(9600);

  stepper.runToNewPosition(2048);
  
  Serial.print("Before: ");
  Serial.println(stepper.currentPosition());

  stepper.setCurrentPosition(0); // sets the current position to whatever is specified inside. eg: 2048 becomes 10, or 0 (as shown here)

  Serial.print("After: ");
  Serial.println(stepper.currentPosition());  
}

void loop() {
}
