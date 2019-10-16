
aUpper="False"
aLower="False"
aNumber="False"
aSpec="False"

def badPasswrd():
    print "That is a bad password"

print "Please enter a potential password and I will see if it's a good one"
password=raw_input()


if len(password) < 6:
    badPasswrd()
else:
    for letter in password:  
        if letter.isupper() == True:
            aUpper="True"
        if letter.islower() == True:
            aLower="True"
        if letter.isalnum() == True:
            aNumber="True"
        else:
            aSpec="True"

    if aUpper and aLower and aNumber and aSpec == "True":
        print "You have a good password"
    else:
        badPasswrd()
