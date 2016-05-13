# Mandelbrot
A blog-like way to Fractals.

This repository is more like a blog, showing the progress to a working Mandelbrot-viewer.
The different versions will show different states of development and optimization.

#Version 1

This is a very basic variant. It only draws the first picture of the Mandelbrot, using the datatypes included in .Net.
You can play with it and see how the different datatypes affect speed.
But it is clear, that double has to be replaced with another datatype with a higher precision.
The only thing slightly optimized in this code is the setting of the pixels, which uses Lockbits, instead of SetPixel().
But here is still room for improvment. In a later version there be a similar variant, to the "ProcessUsingLockbitsAndUnsafe" method, described in this blogpost: http://csharpexamples.com/fast-image-processing-c/.

For everone interested, the algorithem calculation the Mandelbrotset is taken from here: http://www.codeproject.com/Tips/650437/Csharp-Simple-Mandelbrot-with-Flicker-Free-Zoom

whereas the coloring of the pixels uses a part from here: https://www.onm8.nl/rendering-mandelbrot-images-with-c-sharp/

A parallel implemantation will follow, as well as further code optimazation, following these ideas:

http://www.dotnetperls.com/optimization

http://www.codeproject.com/Tips/447938/High-performance-Csharp-byte-array-to-hex-string-t //Later for the custom datatype
