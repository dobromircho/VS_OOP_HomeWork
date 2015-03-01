using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DogMeeting
{
    static void Main()
    {
        int age;
        Console.Write("Enter your name :");
        string name = Console.ReadLine();
        Console.Write("Enter your age :");
        bool isAge = int.TryParse(Console.ReadLine(), out age);
        if (!isAge)
        {
            Console.WriteLine("Age should be numbers !!!");
            return;
        }
        try
        {
            Person person = new Person(name, age);
            Console.WriteLine("Hello {0} !",name);
            Console.WriteLine("Your age is {0}",age);

        }
        catch (Exception ex)
        {

            Console.WriteLine("Cannot create person" + ex);
        }
    }

}

