import re

with open('C:\\Roshan\\findme.txt') as f:
    for line in f:
        pattern = r'"([A-Za-z0-9_ \./\\-]*)"'
    
        res = re.search(pattern, line)

        if res is None :
                print "No Match"
        else:
            print res.group()
         


'''
wordList=[]

startChar='\"'
endChar='\"'

targetFile=open('C:\\Roshan\\findme.txt')

contents=targetFile.read()
contents.splitlines()

for line in contents:
    pattern = r'"([A-Za-z0-9_\./\\-]*)"'
    
    res = re.search(pattern, contents)
    print res.group()

    

for letter in contents:
    if letter == startChar:
        wordList.append(letter)
    
            
print wordList
'''
