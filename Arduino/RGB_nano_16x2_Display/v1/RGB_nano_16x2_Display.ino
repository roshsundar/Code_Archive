#include <Wire.h>
#include "Adafruit_TCS34725.h"
#include <LiquidCrystal.h>

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

int final_red, final_green, final_blue;
float red, green, blue;

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

 red = (float(r)/float(c)) * 255;
 green = (float(g) / float(c)) * 255;
 blue = (float(b) / float(c)) * 255;
 
 final_red = round(512 * (red / (red+green+blue)));
 final_green = round(512 * (green / (red+green+blue)));
 final_blue = round(512 * (blue / (red+green+blue)));
  
  String dispstring = final_red + String(", ")  + final_green + String(", ")  + final_blue;
  lcd.clear();
  lcd.print("Red, Green, Blue");
  lcd.setCursor(0,1);
  lcd.print(dispstring);
  lcd.display();
}
