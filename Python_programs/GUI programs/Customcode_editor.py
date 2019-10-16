from Tkinter import *

def run_prog():
    code = editor.get('1.0', END).splitlines()

    for line in code:
        if "Say(" in line:
            output=re.search(r"\(([A-Za-z0-9_-]+)\)", line)
            print output.group(1)

        if "Subtract(" in line:
            output=re.search(r"\(([0-9-]+)\)",line)
            print eval(output.group(1))

        if "Add(" in line:
            output=re.search(r"\(([0-9+]+)\)",line)
            print eval(output.group(1))

        if "Multipy(" in line:
            output=re.search(r"\(([0-9*]+)\)",line)
            print eval(output.group(1))

        if "Divide(" in line:
            output=re.search(r"\(([0-9\/]+)\)",line)
            print eval(output.group(1))

        if "standMath(" in line:
            output=re.search(r"\(([0-9\/*+-]+)\)",line)
            print eval(output.group(1))

        if "defVar(" in line:
            output=re.search(r"\(([A-Za-z0-9_=]+)\)", line)
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
