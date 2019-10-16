from Tkinter import *
import turtle

def calcResults():

    global C
    global A
    global drawer
    
    pi=3.14159
    radius=float(e1.get())

    circumference=str(radius*2*pi)
    area=str(radius*radius*pi)

    C.set(circumference)
    A.set(area)

    drawer.circle(radius)

main=Tk()

C=StringVar()
A=StringVar()

Label(main, text="Circle radius").grid(row=0)

e1=Entry(main)
e1.grid(row=0, column=1)

Button(main, text="Calculate", command=calcResults).grid(row=1)

circLabel=Label(main, textvariable=C)
circLabel.grid(row=2)

areaLabel=Label(main, textvariable=A)
areaLabel.grid(row=3)

wn=turtle.Screen()

drawer=turtle.Turtle()

wn._root.mainloop()


main.mainloop()

