print "Please enter the directory of the file you want to search for emails in."
userDir = raw_input()

myfile = open(userDir, 'r')

contents = myfile.readlines()


counter = 1
foundEmail = False

for line in contents:
    
    if '@' in line and '.' in line:
        print "I found a email in line",counter
        foundEmail = True

    counter += 1


if foundEmail == False:
    print "There are no emails"
