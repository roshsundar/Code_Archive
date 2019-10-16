#include <Servo.h>

Servo myservo;

void setup() {
  myservo.attach(35);
}

void loop() {
  myservo.write(130);
}
