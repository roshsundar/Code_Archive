#set the beginning to on
dumpFile = open('Dump_for_comm', 'w').close() # clears the text file

dumpFile = open('Dump_for_comm', 'w')
dumpFile.write('on')
dumpFile.close()

stop = False

while stop == False:

    choice = raw_input('Do you want to light the square? (Yes or No) or quit(quit) >> ')
    choice.lower()

    if choice == 'yes':
        dumpFile = open('Dump_for_comm', 'w').close() # clears the text file

        dumpFile = open('Dump_for_comm', 'w')
        dumpFile.write('on')
        dumpFile.close()
    elif choice == 'no':
        dumpFile = open('Dump_for_comm', 'w').close() # clears the text file
        
        dumpFile = open('Dump_for_comm', 'w')
        dumpFile.write('off')
        dumpFile.close()
    elif choice == 'quit':
        stop = True

    else:
        print 'ERROR: NOT A VALID CHOICE'
        

dumpFile = open('Dump_for_comm', 'w').close() # clears the text file

dumpFile = open('Dump_for_comm', 'w')
dumpFile.write('quit')
dumpFile.close()    
