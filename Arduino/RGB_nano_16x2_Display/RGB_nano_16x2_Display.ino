#include <Wire.h>
#include "Adafruit_TCS34725.h"
#include <LiquidCrystal.h>

//version 2

/* Initialise with specific int time and gain values */
Adafruit_TCS34725 tcs = Adafruit_TCS34725(TCS34725_INTEGRATIONTIME_700MS, TCS34725_GAIN_1X);

/*
 Arduino Nano
 LCD RS -> nano D2
 LCD E -> nano D3
 LCD D4,D5,D6,D7 -> nano D4,D5,D6,D7
*/

// nano pins
LiquidCrystal lcd(2,3,4,5,6,7);

int red, green, blue;

void setup() {
  // 16 columns x 2 rows
  lcd.begin(16,2);
        
  if (tcs.begin()) {
        lcd.print("Found sensor");
          lcd.display();         
    } else {
        lcd.print("No TCS34725 found ... check your connections");
        lcd.display();
        while (1);
    }

    lcd.noDisplay();

}

void loop() {

  uint16_t r, g, b, c;

 
  lcd.display();  
  //https://forums.adafruit.com/viewtopic.php?f=8&t=67795&sid=13941bdda4856aaf91e9951b0dc141f0&start=15
  tcs.getRawData(&r, &g, &b, &c);

 red = round((float(r)/float(c)) * 255);
 green = round((float(g) / float(c)) * 255);
 blue = round((float(b) / float(c)) * 255);
 
  
  String dispstring = red + String(", ")  + green + String(", ")  + blue;
  lcd.clear();
  lcd.print("Red, Green, Blue");
  lcd.setCursor(0,1);
  lcd.print(dispstring);
  lcd.display();
}
