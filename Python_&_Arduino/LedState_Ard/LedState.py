# This program is meant to create a graphical representation of the led on the arduino

import serial
import turtle

dumpFile = open('LedState_dump', 'w').close() # Clear the dump file

serData = serial.Serial('com5', 9600)

while True:
    if serData.inWaiting() > 0:
        myData = str(serData.readline()).rstrip('\n')

        print myData

        if 'on' in myData :
            dumpFile = open('LedState_dump', 'w')
            dumpFile.write('on')
            dumpFile.close()          
        elif 'off' in myData:
            dumpFile = open('LedState_dump', 'w')
            dumpFile.write('off')
            dumpFile.close()
             
            
        

