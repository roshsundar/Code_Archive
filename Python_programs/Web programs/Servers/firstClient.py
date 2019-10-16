import socket

def Main():
    host = "192.168.1.100"
    port = 5002

    s = socket.socket()
    s.connect((host, port))

    message = raw_input("->")

    while message != 'quit':
        s.send(message) # send the data
        data = s.recv(1024) # recieve the modified data
        print "Recieved from server: " + str(data) # display result
        #----Input to server is here----
        message = raw_input("->")
        #-------------------------------
    s.close()

if __name__ == "__main__":
    Main()
