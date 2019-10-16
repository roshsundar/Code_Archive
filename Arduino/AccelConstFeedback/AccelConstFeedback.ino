#include <AccelStepper.h>
#include <AccelHelper.h>  //My own helper lib in AccelStepper
#define HALFSTEP 8

float targetStep = 0;

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
   stepper.setAcceleration(700); // set acceleration in steps per sec
   targetStep = angleToSteps(120);
   stepper.runToNewPosition(targetStep); // goes to a specified position, use '-' to specify direction (CCW). if the value > 4096, then it will go over how many is left over from 4096
   Serial.begin(9600);
   
}

void loop()
{ 
  float steps,angle,pos,myangle;
  for(angle=120; angle<=180; angle++){
    steps=angleToSteps(angle);
    stepper.runToNewPosition(steps);
    pos = stepper.currentPosition();
    myangle=stepsToAngle(pos);
    Serial.println(myangle);
  }
  
  
  
}

