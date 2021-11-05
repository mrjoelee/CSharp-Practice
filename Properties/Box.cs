using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Box
    {
     
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int FrontSurface
        {
            get
            {
                return (Height + Width + Length) * 2;
            }
        }

        public Box(int Height, int Width, int Length)
        {
            this.Height = Height;
            this.Width = Width;
            this.Length = Length;
        }

        public void DisplayFrontSurface()
        {
            Console.WriteLine($"Height is {Height}, Width is {Width}, Length is {Length} and the FrontSurface is {FrontSurface} ");
        }

    }
}
