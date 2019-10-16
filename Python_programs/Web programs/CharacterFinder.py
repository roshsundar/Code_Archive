import urllib
import re

Occurences=0
site1="http://jshawl.com/python-playground/"
site2="https://www.google.com"

sourceCode=urllib.urlopen(site2).read()

List_of_Occurences=re.findall('@', sourceCode)

print List_of_Occurences

for letter in List_of_Occurences:
    Occurences +=1

print "I have found",Occurences,"Occurences in this page"
    

