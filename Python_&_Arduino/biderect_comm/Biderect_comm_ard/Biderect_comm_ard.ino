
/* This program listens for data from python, and if the data is a keyword, it sends back an indicator */

String data;
int mydata;

void setup() {
  Serial.begin(9600); // Initialize serial port
}

void loop() {
  if (Serial.available() > 0) // If data in serial port
  {
    data = Serial.readString();
    mydata = data.toInt();
    mydata = mydata + 5;
    Serial.println(mydata); // If data is go, send an indicator that it has been recieved
  }
}
