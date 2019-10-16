#include<Mouse.h>

/* ONLY WORKS FOR CERTAIN BOARDS: Leonardo, Micro, or Due */

// pins for the buttons to control mouse
#define UPBUTTON 5
#define RIGHTBUTTON 4
#define DOWNBUTTON 8
#define LEFTBUTTON 6
#define CLICKBUTTON 7

// states for the buttons
int upState = 0;
int rightState= 0;
int downState = 0;
int leftState = 0;
int clickState = 0;

// movement distances for the mouse
int xDistance = 0;
int yDistance = 0;

int range = 5; // output range of X or Y movement, effects the movement speed
int responseDelay = 10; // response delay of mouse in milliseconds
void setup() {
  pinMode(UPBUTTON, INPUT);
  pinMode(RIGHTBUTTON, INPUT);
  pinMode(DOWNBUTTON, INPUT);
  pinMode(LEFTBUTTON, INPUT);
  pinMode(CLICKBUTTON, INPUT);

  // initialize mouse control
  Mouse.begin();
}

void loop() {
  // read buttons
  upState = digitalRead(UPBUTTON);
  rightState= digitalRead(RIGHTBUTTON);
  downState = digitalRead(DOWNBUTTON);
  leftState = digitalRead(LEFTBUTTON);
  clickState = digitalRead(CLICKBUTTON);

  // calculate the movement
  xDistance = (leftState - rightState) * range;
  yDistance = (upState - downState) * range;
  
  // if the X or Y isn't 0 then move
  if ((xDistance != 0) || (yDistance !=0)
  {
    Mouse.move(xDistance, yDistance, 0);
  }

  // if the mouse button is pressed:
  if (clickState == HIGH)
  {
    // if the mouse isn't pressed, press it
    if(!Mouse.isPressed(MOUSE_LEFT))
    {
      Mouse.press(MOUSE_LEFT);
    }
  }
  // else the mouse button isn't pressed
  else
  {
    // if the mouse is pressed, release it
    if (Mouse.isPressed(MOUSE_LEFT))
    {
      Mouse.release(MOUSE_LEFT);
    }
  }

  // delay so the mouse doesn't move too fast
  delay(responseDelay);
}
