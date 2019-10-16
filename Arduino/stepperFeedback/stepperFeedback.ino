#include <AccelStepper.h>
#define HALFSTEP 8

float pos;
//declare variables for the motor pins
int motorPin1 = 35;      // Blue   - 28BYJ48 pin 1
int motorPin2 = 37;      // Pink   - 28BYJ48 pin 2
int motorPin3 = 39;     // Yellow - 28BYJ48 pin 3
int motorPin4 = 41;     // Orange - 28BYJ48 pin 4
// Red    - 28BYJ48 pin 5 (VCC)

AccelStepper stepper(HALFSTEP, motorPin1, motorPin3, motorPin2, motorPin4);

void setup()
{  
   stepper.setMaxSpeed(1000); //steps per second. Must be > 0. run() will accelerate upto this value.
   stepper.setAcceleration(400);

   Serial.begin(9600);
}

void loop()
{ 
  stepper.runToNewPosition(1024);
  pos = stepper.currentPosition(); // will be relative to starting position = 0(upon powerup)
  Serial.println(pos);
}

