import urllib

site1 = "https://www.google.com"

source = urllib.urlopen(site1)

print source.read()
