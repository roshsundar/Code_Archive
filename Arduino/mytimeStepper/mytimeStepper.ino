#include <AccelStepper.h>
#include <timeObj.h>
#define HALFSTEP 8

/* pins for stepper1 */
int step1Pin1 = 35;   
int step1Pin2 = 37;  
int step1Pin3 = 39;  
int step1Pin4 = 41;


/* pins for stepper2 */
int step2Pin1 = 47;   
int step2Pin2 = 49;  
int step2Pin3 = 51;  
int step2Pin4 = 53;

timeObj motorTimer(8000);
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
  runMotor1ForTime();
  runMotor2ForTime();
}

void runMotor1ForTime(){
  int i = 0;
  motorTimer.start();
  while (i != 1)
  {
    if (motorTimer.ding())
    {
      i = 1;
    }
    else
    {
      stepper1.runSpeed();
    }
  }
}
void runMotor2ForTime(){
  int i = 0;
  motorTimer.start();
  while (i != 1)
  {
    if (motorTimer.ding())
    {
      i = 1;
    }
    else
    {
      stepper2.runSpeed();
    }
  }
}
