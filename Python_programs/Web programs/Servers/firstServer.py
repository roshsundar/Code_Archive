import socket

def Main():
    host = "192.168.1.100"
    port = 5002

    s = socket.socket()
    #s.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    s.bind((host, port))

    s.listen(1)
    c, addr = s.accept()
    print "Connection from: " + str(addr)
    
    while True:
        data = c.recv(1024)
        if not data:
            break
        #----Data processing happens here----
        print "from connected user: " + str(data)
        data = str(data).upper()
        print "sending: " + str(data)
        #------------------------------------
        c.send(data)
    c.close()

if __name__ == "__main__":
    Main()
