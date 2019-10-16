import socket

def Main():
    host = '192.168.1.100'
    port = 5002

    s = socket.socket()
    s.bind((host, port))

    s.listen(1)
    c,adr = s.accept()

    while True:
        feedback = c.recv(1024)
        if not feedback:
            break

        print 'FRIEND: ' + str(feedback)

        message = raw_input('YOU: ')

        c.send(message)
    c.close()

if __name__ == '__main__':
    Main()
