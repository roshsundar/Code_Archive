#include <AccelStepper.h>
#include <MultiStepper.h>
#define HALFSTEP 8

//StepperMotor 1 pins:
//declare variables for the motor pins
int Step1Pin1 = 35;      // Blue   - 28BYJ48 pin 1
int Step1Pin2 = 37;      // Pink   - 28BYJ48 pin 2
int Step1Pin3 = 39;     // Yellow - 28BYJ48 pin 3
int Step1Pin4 = 41;     // Orange - 28BYJ48 pin 4
// Red    - 28BYJ48 pin 5 (VCC)

//StepperMotor 1 pins:
//declare variables for the motor pins
int Step2Pin1 = 47;      // Blue   - 28BYJ48 pin 1
int Step2Pin2 = 49;      // Pink   - 28BYJ48 pin 2
int Step2Pin3 = 51;     // Yellow - 28BYJ48 pin 3
int Step2Pin4 = 53;     // Orange - 28BYJ48 pin 4
// Red    - 28BYJ48 pin 5 (VCC)

AccelStepper stepper1(HALFSTEP, Step1Pin1, Step1Pin3, Step1Pin2, Step1Pin4);
AccelStepper stepper2(HALFSTEP, Step2Pin1, Step2Pin3, Step2Pin2, Step2Pin4);


MultiStepper allStepperz;

void setup()
{  

   stepper1.setMaxSpeed(1000);
   stepper1.setSpeed(500);

   stepper2.setMaxSpeed(1000);
   stepper2.setSpeed(500);
   
   allStepperz.addStepper(stepper1);
   allStepperz.addStepper(stepper2);

}

void loop()
{ 

  long positions[2]; // Array of desired stepper positions
  
  positions[0] = 2048;
  positions[1] = 2048;
  allStepperz.moveTo(positions);
  allStepperz.runSpeedToPosition(); // Blocks until all are in position
  delay(1000);
  
  // Move to a different coordinate
  positions[0] = 0; //values example: 512, 0 ,or -512
  positions[1] = 0;
  allStepperz.moveTo(positions);
  allStepperz.runSpeedToPosition(); // Blocks until all are in position
  delay(1000);
  
}

