using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Call
{
    private DateTime dates;
    private string phoneNumbers;
    private int durations;

    public Call() { }

    public Call(DateTime date, string phoneNumber, int durationSeconds)
    {
        this.Date = DateTime.Now;
        this.PhoneNumber = phoneNumber;
        this.DurationSeconds = durationSeconds;
    }

    public DateTime Date
    {
        get { return this.dates.Date; }
        set { this.dates = value; }
    }
    
    public string PhoneNumber
    {
        get { return this.phoneNumbers; }
        set
        {
            if (value.Length < 7 || value.Length > 15 )
            {
                Console.WriteLine("Invalid Length");
            }
            foreach (char ch in value)
            {
                if (!char.IsDigit(ch) && ch != '+')
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            this.phoneNumbers = value;
        }
    }

    public int DurationSeconds
    {
        get { return this.durations; }
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Invalid Duration");
            }
            this.durations = value;
        }
    }
}

