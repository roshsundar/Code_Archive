from Tkinter import *
import random

def gen_num():
    lower=int(e1.get())
    higher=int(e2.get())
    number=random.randint(lower, higher)
    Label(main, text=number).grid(row=3, column=1)

main=Tk()

Label(main, text="Lowest possible number").grid(row=0, column=0)
Label(main, text="Highest possible number").grid(row=1, column=0)


e1= Entry(main)
e2= Entry(main)

e1.grid(row=0, column=1)
e2.grid(row=1, column=1)

Button(main, text="Generate", command=gen_num).grid(row=2, column=1)

main.mainloop()
