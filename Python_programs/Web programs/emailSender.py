#dont call any email programs 'email.py'

#You also have to turn on "App Access' in your Gmail security settings.
#Otherwise, it'll fail authentication. (SMTPAuthenticationError)


import smtplib

content = "This is a test" # content that will go into the enail

mail = smtplib.SMTP("smtp.gmail.com", 587) # 1-server 2-port(number might change)

mail.ehlo() #identify yourself to the server

mail.starttls() #start TLS - encrypts all data after this

mail.login('roshsundar@gmail.com', 'xxxxxxx') #login 1-email 2-password

mail.sendmail('roshsundar@gmail.com', 'roshsundar@gmail.com', content) #send the mail  1-from 2-to 3-content

mail.close() #close the connection



#https://www.youtube.com/watch?v=gzv183G9Vew  Link to tutorial video
