using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class GSM
{
    private string model;
    private string manifacturer;
    private float price;
    private string owner;
    private static GSM iphone4s;
    private List<Call> callHistory = new List<Call>();

    public GSM() { }

    public GSM(string model= "000", string manifacturer="XYZ", int price =0, string owner="X")
    {
        this.Model = model;
        this.Manifacturer = manifacturer;
        this.Price = price;
        this.Owner = owner;
    }

    public void CalculateSum(float pricePerMinute)
    {
        int totalSeconds = 0;
        foreach (Call call in callHistory)
        {
            totalSeconds += call.DurationSeconds;
        }
        float minutes = (float)totalSeconds / 60;
        Console.WriteLine("Price pre minute : {0} lv.\nTotal Minutes : {1:0.00} \nTotal Price : {2} lv.", pricePerMinute ,minutes ,minutes * pricePerMinute);
    }

    public void AddCall(Call call)
    {
        this.callHistory.Add(call);
    }
    public void DeleteCall(int indexe)
    {
        this.callHistory.RemoveAt(indexe);
    }
    public void ClearCalls()
    {
        this.callHistory.Clear();
    }
    public void RemoveLongestCall()
    {
        int maxSec = 0;
        int currSec = 0;
        int index = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            currSec = callHistory[i].DurationSeconds;
            if (currSec > maxSec)
            {
                maxSec = currSec;
                index = i;
            }
        }
        this.callHistory.RemoveAt(index);
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value; }
    }

    public static GSM  Iphone4s
    {
        get { return iphone4s; }
        set { iphone4s = value; }
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Length < 2 || value.Length >20)
            {
                Console.WriteLine("Wrong Model");
                Glaven.Main();
            }
            foreach (char ch in value)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    Console.WriteLine("Incorrect Model");
                    Glaven.Main();
                }
            }
            this.model = value;
        }
    }
    public string Manifacturer
    {
        get { return this.manifacturer; }
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                Console.WriteLine("Incorrect Manifacturer");
                Glaven.Main();
            }
            this.manifacturer = value;
        }
    }
    public float Price
    {
        get { return this.price; }
        set
        {
            if (value < 0 || value > float.MaxValue)
            {
                Console.WriteLine("Ivalid Price");
                Glaven.Main();
            }
            this.price = value;
        }
    }
    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                Console.WriteLine("Invalid Length of Name!!!");
                Glaven.Main();
            }
            foreach (char ch in value)
            {
                if (!char.IsLetter(ch) && ch != ' ' )
                {
                    Console.WriteLine("Invalid Name!!!");
                    Glaven.Main();
                }
            }
            this.owner = value;
        }
    }

    public override string ToString()
    {
        Console.WriteLine("MODEL : {0} \n\nMANIFACTURER : {1} \n\nPRICE : {2:0.00}leva \n\nOWNER : {3}",model,manifacturer,price,owner);
        return base.ToString();
    }
}
