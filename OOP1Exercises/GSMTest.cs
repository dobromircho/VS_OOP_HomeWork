using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class GSMTest
{
    public static  GSM[] gsmArray = new GSM[4];
    public static void CreateArray()
    {
        
        gsmArray[0] = new GSM("3310", "Kokia", 150, "Ivan");
        gsmArray[1] = new GSM("G2", "LG", 750, "Pesho");
        gsmArray[2] = new GSM("Y300", "Huiawei", 360, "Dobri");
        gsmArray[3] = new GSM("S5", "Samsung", 780, "Joro");
    }
    public static void ShowArray()
    {
        foreach (var arr in gsmArray)
        {
            Console.WriteLine(arr.ToString());
        }
    }
    public static void ShowIphone()
    {
        GSM iphone = new GSM("4S","Apple",1460,"Simeon");
        GSM.Iphone4s = iphone;
        GSM.Iphone4s.ToString();

    }
}
