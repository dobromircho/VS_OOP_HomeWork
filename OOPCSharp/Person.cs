using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Empty Name");
            }
            if (value.Length < 2)
            {
                throw new ArgumentException("Name is too short");
            }
            if (value.Length > 50)
            {
                throw new ArgumentException("Name is too long");
            }
            foreach (char ch in value)
            {
                if (!IsLetterAllowed(ch))
                {
                    throw new ArgumentException("Not allowed letter");
                }
            }
            this.name = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Invalid AGE");
            }
            this.age = value;
        }
    }

    private bool IsLetterAllowed(char ch)
    {
        bool isAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }
}

