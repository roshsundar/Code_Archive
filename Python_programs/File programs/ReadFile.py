myfile = open('pythonWrite_to', 'r')
text = myfile.read() # you can pass a value into the fuction if you only want to read a certain amount of bytes
myfile.close()

print text
