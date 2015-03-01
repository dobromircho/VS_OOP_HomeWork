using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Battery : GSM
{
    private string batteryModel;
    private int idleHours;
    private int talkHours;

    public enum BatteryType { Liion,NiMH,NiCd}

    public Battery() { }
    public Battery(string batteryModel, int idleHours, int talkHours)
    {
        this.BatteryModel = batteryModel;
        this.IdleHours = idleHours;
        this.TalkHours = talkHours;
    }

    public string BatteryModel
    {
        get { return this.batteryModel; }
        set { this.batteryModel = value; }
    }
    public int IdleHours
    {
        get { return this.idleHours; }
        set
        {
            if (value < 0 )
            {
                Console.WriteLine("Invalid Idle time");
            }
            this.idleHours = value;
        }
    }
    public int TalkHours
    {
        get { return this.talkHours; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Invalid talk time");
            }
            this.talkHours = value;
        }
    }
}

