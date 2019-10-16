import winsound

# 0000 = no sound
# 0001 = Low C
# 0010 = D
# 0011 = E
# 0100 = F
# 0101 = G
# 0110 = A
# 0111 = B
# 1000 = High C

print "Enter the duration of each note (in ms)?"
print "e.g. 200"
rate = int(input('->'))

print "Please enter a sequence to create the sound"
binSound = raw_input('->')

for note in binSound.split():
    if note == "0000":      # rest
        freq = 37
    elif note == "0001":    # low c
        freq = 262
    elif note == "0010":    # d
        freq = 294
    elif note == "0011":    # e
        freq = 330
    elif note == "0100":    # f
        freq = 349
    elif note == "0101":    # g
        freq = 392
    elif note == "0110":    # a
        freq == 440
    elif note == "0111":    # b
        freq = 494
    elif note == "1000":    # high c
        freq = 523

    winsound.Beep(freq, rate)
