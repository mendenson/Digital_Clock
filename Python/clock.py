from ctypes import alignment
from tkinter import *
import tkinter
import pyglet

from datetime import datetime

# define some colors
color1 = "#3d3d3d" # black
color2 = "#21c25c" # green

root = Tk()
root.title("")
root.geometry('800x350')
root.resizable(width=FALSE, height=FALSE)
root.configure(background=color1)

l1 = Label(root, font=('digital-7 170'), bg=color1, fg=color2)
l1.grid(row=0, column=0, sticky=W+E)

l2 = Label(root, font=('digital-7 60'), bg=color1, fg=color2)
l2.grid(row=1, column=0, sticky=W+E)

def clock():
    time = datetime.now()
    hour = time.strftime("%H:%M:%S")
    weekday = time.strftime("%A")
    day = time.day
    month = time.strftime("%b")
    year = time.strftime("%Y")

    l1.config(text=hour)
    l1.after(200, clock)

    l2.config(text=weekday + " " + str(day) + "/" + str(month) + "/" + (year))

clock()
root.mainloop()

