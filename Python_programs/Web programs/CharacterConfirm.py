import urllib
import re

site=urllib.urlopen("http://jshawl.com/python-playground/").read()

print '@' in site
