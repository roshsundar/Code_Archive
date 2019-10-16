
occurences=0

print "Please enter a group of words"
userPut=raw_input()

print "Now enter a character that you want me to find in it"
charac=raw_input()

for letter in userPut:
    if letter == charac:
        occurences += 1


print "I found",occurences,"ocurrences of your character in the words"
