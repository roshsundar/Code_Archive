#This progam is meant to read any data from the arduino (a tester so to speak)

import serial    # imports the module that reads data from ardunio serial port

serData = serial.Serial('com5', 9600)   # variable that holds the values from arduino serial port
                                        # takes 2 arguments, port & baud rate (matches what is set in arduino code

while True:
    if serData.inWaiting() > 0: # this if will check if there is data in the serial port of the arduino
        myData = serData.readline() # this variable reads the serial data and puts it into a new variable to be used

        print myData    # prints the line of serial data from arduino
        
                        
