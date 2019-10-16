#include <AccelStepper.h>
#define HALFSTEP 8

/* pins for stepper1 */
int step1Pin1 = 35;      // Blue   - 28BYJ48 pin 1
int step1Pin2 = 37;      // Pink   - 28BYJ48 pin 2
int step1Pin3 = 39;     // Yellow - 28BYJ48 pin 3
int step1Pin4 = 41;     // Orange - 28BYJ48 pin 4
// Red    - 28BYJ48 pin 5 (VCC)

/* pins for stepper2 */
int step2Pin1 = 47;      // Blue   - 28BYJ48 pin 1
int step2Pin2 = 49;      // Pink   - 28BYJ48 pin 2
int step2Pin3 = 51;     // Yellow - 28BYJ48 pin 3
int step2Pin4 = 53;     // Orange - 28BYJ48 pin 4
// Red    - 28BYJ48 pin 5 (VCC)

AccelStepper stepper1(HALFSTEP, step1Pin1, step1Pin3, step1Pin2, step1Pin4);
AccelStepper stepper2(HALFSTEP, step2Pin1, step2Pin3, step2Pin2, step2Pin4);

void setup()
{  
   stepper1.setMaxSpeed(1000); //steps per second. Must be > 0. run() will accelerate upto this value.
   stepper1.setSpeed(512);  //steps per second. Positive CW. 0=stop. Negative CCW. See manual for more info.

   stepper2.setMaxSpeed(1000); //steps per second. Must be > 0. run() will accelerate upto this value.
   stepper2.setSpeed(512);  //steps per second. Positive CW. 0=stop. Negative CCW. See manual for more info.
}

void loop()
{ 
  stepper1.runSpeed();
  stepper2.runSpeed();
}

