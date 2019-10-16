import socket

def main():
    host = "192.168.1.100"
    port = 5002

    s = socket.socket()
    s.connect((host, port))

    message = raw_input('YOU: ')

    while message != 'quit':
        s.send(message)
        feedback = s.recv(1024)
        print 'FRIEND: ' + str(feedback)

        message = raw_input('YOU: ')

    s.close()

if __name__ == '__main__':
    main()
