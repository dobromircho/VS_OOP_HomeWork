using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Display : GSM
{
    private int size;
    private int colors;


    public Display() { }
    public Display(int size, int colors)
    {
        this.Size = size;
        this.Colors = colors;
    }

    public int Size
    {
        get { return this.size; }
        set
        {
            if (value < 2 || value > 10)
            {
                Console.WriteLine("Invalid size!!!");
            }
            this.size = value;
        }
    }
    public int Colors
    {
        get { return this.colors; }
        set
        {
            if (value < 16000 || value > 16000000)
            {
                Console.WriteLine("Incorrect colors");
            }
            this.colors = value;
        }
    }

}