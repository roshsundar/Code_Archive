import turtle

wn = turtle.Screen()

blink = turtle.Turtle()
blink.shape('square')
blink.color('orange')

while True:
    dumpFile = open('LedState_dump', 'r')
    text = dumpfile.readline()
    dumpFile.close()

    print text

    if text == 'on':
        blink.st()
    elif text == 'off':
        blink.ht()
