import re

print "How many times do you want to ask me a question?"
times=input()

good_list=['nice','good']
bad_list=['stupid','ugly']

counter=1

while counter<=times:
    
    print "Please ask me a (yes or no) question (all lowercase please!)"
    question=raw_input()
    
    if "not stupid" in question and "i" in question:
        print "no"

    elif "i" and "stupid" in question and "not" not in question:
        print "Yes"
 
    counter=counter+1

    
