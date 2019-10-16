
newList=[]

print "Please type in a word"
word = raw_input()

characWord = list(word)

for letter in reversed(characWord):
    newList.append(letter)


print ''.join(newList)
    
    
