import turtle

wn = turtle.Screen()

blink = turtle.Turtle()
blink.shape('square')
blink.color('red')
blink.ht()

def Read_show():
    dumpFile = open('Dump_for_comm', 'r')
    text = dumpFile.readline()
    dumpFile.close()

    print text

    if text == 'on':
        blink.st()
    elif text == 'off':
        blink.ht()
    elif text == 'quit':
        stop = True

stop = False

while stop == False:
    Read_show()

    
