using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Part : IEquatable<Part>
{
    public string PartName { get; set; }

    public int PartId { get; set; }

    public override string ToString()
    {
        return "ID: " + PartId + "   Name: " + PartName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        return PartId;
    }
    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
    // Should also override == and != operators.

}

class Glaven
{
    public static void Main()
    {
        Console.WriteLine();
        GSM gsm = new GSM();
        Random rand = new Random();
        Call call1 = new Call(DateTime.Now, "+35934345345",100);
        Call call2 = new Call(DateTime.Now, "+44934345452",200);
        Call call3 = new Call(DateTime.Now, "+373934345345",440);
        Call call4 = new Call(DateTime.Now, "+321134345345",505);
        gsm.AddCall(call1);
        gsm.AddCall(call2);
        gsm.AddCall(call3);
        gsm.AddCall(call4);
        gsm.RemoveLongestCall();
        gsm.ClearCalls();
        foreach (Call item in gsm.CallHistory)
        {
            Console.WriteLine("Date : {0}",item.Date);
            Console.WriteLine("Number : {0}",item.PhoneNumber);
            Console.WriteLine("Duration : {0} sec",item.DurationSeconds);
            Console.WriteLine();
        }
        gsm.CalculateSum(0.37f);
    }
}

