#include <timeObj.h>

timeObj ledTimer(3000); // define a timer object // in milliseconds
void setup() {
  pinMode(13, OUTPUT);
  ledTimer.start(); // start the timer
}

void loop() {
  if (ledTimer.ding()) // if the timer time passed
  {
    digitalWrite(13, LOW);
  }
  else
  {
    digitalWrite(13, HIGH);
  }
}
