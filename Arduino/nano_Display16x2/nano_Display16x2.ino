#include <LiquidCrystal.h>

/*
 Arduino Nano
 LCD RS -> nano D2
 LCD E -> nano D3
 LCD D4,D5,D6,D7 -> nano D4,D5,D6,D7
*/

// nano pins
LiquidCrystal lcd(2,3,4,5,6,7);

void setup() {
  // 16 columns x 2 rows
  lcd.begin(16,2);
  // Message
  lcd.print("Anya Sundar");
}

void loop() {
  // Turn off the display:
 
  // Turn on the display:
  lcd.display();
  
}
