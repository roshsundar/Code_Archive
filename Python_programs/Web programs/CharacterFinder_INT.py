import urllib
import re

Occurences=0

print "Please enter a site that I can search (url)"
Url=raw_input()

print "Please enter the general name of the site (google, cool math)"
name=raw_input()

print "Please enter a character or sequence to find"
searchFor=raw_input()

sourceCode=urllib.urlopen(Url).read()

List_of_Occurences=re.findall(searchFor, sourceCode)

print List_of_Occurences

for letter in List_of_Occurences:
    Occurences += 1

print "I have found",Occurences,"Occurences in",name 
