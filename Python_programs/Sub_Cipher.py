
cipherKey = {'a' : '@',
             'b' : '!',
             'c' : '<',
             'd' : '&',
             'e' : '(',
             'f' : '[',
             'g' : '9',
             'h' : '#',
             'i' : '1',
             'j' : '}',
             'k' : '/',
             'l' : '|',
             'm' : '^',
             'n' : '%',
             'o' : '0',
             'p' : '*',
             'q' : '?',
             'r' : '\\',
             's' : '$',
             't' : '+',
             'u' : '-',
             'v' : '8',
             'w' : ':',
             'x' : '`',
             'y' : '=',
             'z' : '7',
             '.' : ';',
             ',' : ',',
             '\"' : '!',
             '\'' : '?',
             ' ' : '_'}

print "Do you want to encode or decode?"
choice = raw_input().lower()

if choice == "encode":
    encoded = ""
    
    print "Please enter a string to encode that doesn't contain special symbols."
    toEncode = raw_input().lower()

    for letter in toEncode:
        enc_letter = cipherKey.get(letter, " This is not in my vocab ")
        encoded = encoded + enc_letter

    print encoded

if choice == "decode":
    
                                   
             
        
