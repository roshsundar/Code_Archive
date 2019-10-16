import urllib
import re

site1="http://jshawl.com/python-playground/"
site2="https://www.google.com"

Occurences=0

sourceCode=urllib.urlopen("http://support.website-creator.org/avoid_spam.html").read()

emails=re.findall("[\w]+@[\w.]+", sourceCode)

print emails

for email in emails:
    Occurences += 1

print "I found",Occurences,"emails in the webpage"
