from Tkinter import *
import turtle

def run_prog():

    code = editor.get('1.0', END).splitlines()

    for line in code:
        if "CreateWindow()" in line: 
            wn=turtle.Screen()

        if "LoopWindow()" in line:
            wn._root.mainloop()

        if "CreateSprite()" in line:
            servant=turtle.Turtle()

        if "Forward(" in line:
            output=re.search(r"\(([0-9-+]+)\)",line)
            servant.forward(output)

        if "Backward(" in line:
            output=re.search(r"\(([0-9-+]+)\)",line)
            servant.backward(output)

        if "Right(" in line:
            output=re.search(r"\(([0-9-+]+)\)",line)
            servant.right(output)

        if "Left(" in line:
            output=re.search(r"\(([0-9-+]+)\)",line)
            servant.right(output)

        if "standMath(" in line:
            output=re.search(r"\(([0-9\/*+-]+)\)",line)
            print eval(output.group(1))
               

main=Tk()

#create scroller and editor
Scroller = Scrollbar(main)
editor = Text(main, height=20, width=50)

#create scroller attributes
Scroller.pack(side=RIGHT, fill=Y)
Scroller.config(command=editor.yview)

#create editor attributes
editor.pack(side=LEFT, fill=Y)
editor.config(yscrollcommand=Scroller.set)

run = Button(main, text="Run", width=25, command=run_prog)
run.pack()

main.mainloop()

