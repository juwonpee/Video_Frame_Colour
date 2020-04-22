from tkinter import *
from tkinter import filedialog as fd
import cv2
import os
import threading

currentframe = 0

def i1button():
    videofile = fd.askopenfilename()
    vie.delete(0, END)
    vie.insert(0, videofile)


def i2button():
    outputfile = fd.asksaveasfilename()
    voe.delete(0, END)
    voe.insert(0, outputfile)


def start():
    videofile = vie.get()
    outputfile = vie.get()

    # check if options are correct
    if videofile != "" and outputfile != "":
        print("start")

        # thread calc
        pl2.config(text="Calculating threads")
        if te.get().isnumeric():
            tl2.config(text=te.get())
            threadno = te.get()
        else:
            tl2.config(text=str(os.cpu_count()))
            threadno = os.cpu_count()

        # initialize
        video = cv2.VideoCapture(videofile)
        if not video.isOpened():
            pl2.config(text="Error loading video")
            return 0

        # get no of frames
        pl2.config(text="Calculating frames")
        length = int(video.get(cv2.CAP_PROP_FRAME_COUNT))
        fl2.config(text=str(length))

        # get dimentions
        pl2.config(text="Calculating dimentions")
        video.set(1,0)
        ret, frame = video.read()
        height, width, channels = frame.shape
        hl2.config(text=str(height))
        wl2.config(text=str(width))

        # compile
        data = []
        compilework = threading.Thread(target=compile, args=(length, video,))
        compilework.start()




        # end

    # if options not correct
    elif videofile == "":
        pl2.config(text="Set video path")
        print("no video")
    elif outputfile == "":
        pl2.config(text="Set output path")


def compile(length, video):
    red, blue, green = [], [], []
    global currentframe
    global data

    for x in range(0, length):
        currentframe = x
        video.set(1, x)
        #ret, frame = video.read()
        pl2.config(text="Compiling: " + str(currentframe + 1) + "/" + str(length))
        print("Compiling: " + str(currentframe + 1) + "/" + str(length))


def quit():
    print("quit")
    sys.exit(0)


# GUI init
window = Tk()
window.title("Video Frame Colour compiler")

# multithreading

# options
vil = Label(window, text="Select Video")
vil.grid(column=0, row=0)
vie = Entry(window)
vie.grid(column=1, row=0)
vib = Button(window, text="File", command=i1button)
vib.grid(column=2, row=0)
vol = Label(window, text="Select output location")
vol.grid(column=0, row=1)
voe = Entry(window)
voe.grid(column=1, row=1)
vob = Button(window, text="File", command=i2button)
vob.grid(column=2, row=1)
nfl1 = Label(window, text="Number of frames to scan")
nfl1.grid(column=0, row=2)
nfe = Entry(window)
nfe.grid(column=1, row=2)
nfl2 = Label(window, text="Empty for whole video")
nfl2.grid(column=1, row=3)
tl = Label(window, text="Number of threads")
tl.grid(column=0, row=4)
te = Entry(window)
te.grid(column=1, row=4)
tl2 = Label(window, text="Empty for Auto")
tl2.grid(column=1, row=5)

# status
vl1 = Label(window, text="Video: ")
vl1.grid(column=0, row=6)
vl2 = Label(window, text="")
vl2.grid(column=1, row=6)
hl1 = Label(window, text="Height:")
hl1.grid(column=0, row=7)
hl2 = Label(window, text="")
hl2.grid(column=1, row=7)
wl1 = Label(window, text="Width:")
wl1.grid(column=0, row=8)
wl2 = Label(window, text="")
wl2.grid(column=1, row=8)
fl1 = Label(window, text="Total frames: ")
fl1.grid(column=0, row=9)
fl2 = Label(window, text="")
fl2.grid(column=1, row=9)
tl1 = Label(window, text="Number of threads:")
tl1.grid(column=0, row=10)
tl2 = Label(window, text="")
tl2.grid(column=1, row=10)
pl1 = Label(window, text="Current progress:")
pl1.grid(column=0, row=11)
pl2 = Label(window, text="")
pl2.grid(column=1, row=11)

# start quit
b3 = Button(window, text="Start", command=start)
b3.grid(column=0, row=12)
b4 = Button(window, text="Quit", command=quit)
b4.grid(column=2, row=12)


window.mainloop()

