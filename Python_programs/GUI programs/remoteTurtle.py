import turtle


mainWN=turtle.Screen()

forward=turtle.Turtle()
forward.ht()
forward.penup()
forward.shape("triangle")
forward.color("green")
forward.seth(90)
forward.setpos(0,50)
forward.st()

backward=turtle.Turtle()
backward.ht()
backward.penup()
backward.shape("triangle")
backward.color("red")
backward.seth(270)
backward.setpos(0,-50)
backward.st()

left=turtle.Turtle()
left.ht()
left.penup()
left.shape("triangle")
left.color("blue")
left.seth(180)
left.setpos(-50,0)
left.st()

right=turtle.Turtle()
right.ht()
right.penup()
right.shape("triangle")
right.color("orange")
right.seth(0)
right.setpos(50,0)
right.st()




mainWN._root.mainloop()

follWN=turtle.Screen()




follWN._root.mainloop()

