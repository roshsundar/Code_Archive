
knowl = {}
close = False

while close != True:
    print "Do you want to (ask) or (enter) a question or quit(q)?"
    choice = raw_input('->')

    if choice == "enter":
        print "Please enter the question."
        questAdd = raw_input('->')

        print "Please enter the answer."
        ansAdd = raw_input('->')

        knowl[questAdd] = ansAdd

    if choice == "ask":
        print "What is the question you want to ask?"
        questAsk = raw_input('->')

        print "The answer is:"
        print knowl.get(questAsk, "ERROR: This question isn't in my knowlege!")

    if choice == 'q':
        close = True

