import serial, time
arduino = serial.Serial('COM5', 9600, timeout=1)
time.sleep(3) #give the connection a second to settle
arduino.write("2")
while True:
    data = arduino.readline()
    if data:
        data = data[:-2]
        myfile = open("C:\\temp\\arduino_data", 'w')
        myfile.write(data)
        myfile.close()
        break
		
