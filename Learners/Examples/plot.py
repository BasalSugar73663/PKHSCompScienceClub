# 
# This program uses the python extension "graphics.py", you're going to need to install that if you want to be able to run this.
# This is a very simple graphing calculator that runs through every vertical line of a window and determines based on the given 
# function where the vertical point for it should be drawn. to  increase readability of the graph, the program also draws a line
# between each successing point.
#

from graphics import *
import math

# Variables declarations
ww = 1000 								# Window width
wh = 1000								# Window height
y = 0									# The y variable of a y=(whatever) function

s = 10									# Scale, The amount of unit present of each side of each axis
sx = ww/(s*2)							# The distance between each unit on the x axis
sy = wh/(s*2)							# The distance between each unit on the y axis

yc = 0									# Which f(x) is currently being run


# The function that determines what value of x gives what value of y, f(x) = whatever. 
def F(x, yc):  							#Takes one paramater which represent the value of x the program needs, and one which represent which function is running in case there are multiple

	x = x_transpose(x)					# Calls the x_transpose function using the value of x as a paramater
	y = x**2							# Function
	y = y_transpose(y)					# Calls the y_transpose function
	print(x, ", ", y)					# Prints the value of x and x in the debug console	

	return y							# Returns the value of y where the function is called


# This makes sure that x is  going to be same scale as was previously defined
def x_transpose(x):
	x -= ww/2
	x = x / sx
	return x


# This makes sure that y is  going to be same scale as was previously defined
def y_transpose(y):
	y = y * sy
	y -= wh/2
	y = -y								# Computers render from the top right, so we need to flip it upside down to get the right orientation
	return y


# Function that makes a line between two points on the screen. x1 & y1 are the coordinates of the first point, x2 & y2 are the coordinates of the second point.
def line(x1, y1, x2, y2):
	ln = Line(Point(x1, y1), Point(x2, y2))
	return ln 


# This is where all the function calls are made and where everything happens
def main():
	d = 0								# Variable that goes through every vertical line of the window
	delta = Point(0, F(0, 0))			# Delta of point, at the end of each cycle, the old point is assigned to this, in order to easily make a line between the two.

	win = GraphWin("Graph Plot", ww, wh)
	win.setBackground(color_rgb(255, 255, 255))

	# Drawing the cross and the line markers
	ln1 = line(ww/2, 0, ww/2, wh)
	ln1.setOutline(color_rgb(0,0,0))
	ln1.setWidth(3)
	ln1.draw(win)
	ln2 = line(0, wh/2, ww, wh/2)
	ln2.setOutline(color_rgb(0,0,0))
	ln2.setWidth(3)
	ln2.draw(win)

	while d <= (s*2):							# This makes a loop that's going to repeat itself until the condition isn't fulfilled
		ln = line(ww/(s*2) * d, wh/2 - 10, ww/(s*2) * d, wh/2 + 10)
		ln.setOutline(color_rgb(0,0,0))
		ln.setWidth(3)
		ln.draw(win)
		d += 1									# Increment d variable
	d = 0										# Reset the d variable after the loop is done

	while d <= (s*2):
		ln = line(ww/2 - 10, wh/(s*2) * d, ww/2 + 10, wh/(s*2) * d)
		ln.setOutline(color_rgb(0,0,0))
		ln.setWidth(3)
		ln.draw(win)
		d += 1									# Increment counter	
	d = 0										# Reset the d variable after the loop is done

	# First f(x)=
	while d != ww:
		y1 = F(d, 0)							# Check what the value of y is for the current x, based on the function we programmed
		pt1 = Point(d, y1)						# Makes a point at our given x value and its y value
		ln = Line(pt1, delta)					# Creates a line between the two points
		ln.setOutline(color_rgb(0, 0, 255))		# Sets the color of the line
		ln.setWidth(3)							# Sets the width of the line
		ln.draw(win)							# Renders the line on the window					
		pt1.setOutline(color_rgb(0, 0, 255))	# Sets the color of our point
		pt1.draw(win)							# Renders the point
		delta = pt1								# Sets the delta
		d += 1									# Increment d variable
	d = 0										# Reset the d variable after the loop is done

	'''
	# Second f(x)=
	while d != ww:
		y1 = F(d, 0)							# Check what the value of y is for the current x, based on the function we programmed
		pt1 = Point(d, y1)						# Makes a point at our given x value and its y value
		ln = Line(pt1, delta)					# Creates a line between the two points
		ln.setOutline(color_rgb(0, 0, 255))		# Sets the color of the line
		ln.setWidth(3)							# Sets the width of the line
		ln.draw(win)							# Renders the line on the window					
		pt1.setOutline(color_rgb(0, 0, 255))	# Sets the color of our point
		pt1.draw(win)							# Renders the point
		delta = pt1								# Sets the delta
		d += 1									# Run the loop until the condition for it isn't fulfilled anymore
	d = 0

	
	# Thrid f(x)=
	while d != ww:
		y1 = F(d, 0)							# Check what the value of y is for the current x, based on the function we programmed
		pt1 = Point(d, y1)						# Makes a point at our given x value and its y value
		ln = Line(pt1, delta)					# Creates a line between the two points
		ln.setOutline(color_rgb(0, 0, 255))		# Sets the color of the line
		ln.setWidth(3)							# Sets the width of the line
		ln.draw(win)							# Renders the line on the window					
		pt1.setOutline(color_rgb(0, 0, 255))	# Sets the color of our point
		pt1.draw(win)							# Renders the point
		delta = pt1								# Sets the delta
		d += 1									# Run the loop until the condition for it isn't fulfilled anymore
	d = 0
	'''

	win.getMouse()								# Pauses the application until it detects a mouse click
	win.close()									# Stops the program

main()											# This is where we start the main loop and the program actually starts

