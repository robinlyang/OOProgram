using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgram
{
    class Time
    {
        public int hour, minute, second;
        //fix print
        public override string ToString()
        {
            return hour + ":" + minute + ":" + second;
        }
        //fix equals
        public override bool Equals(object obj)
        {
            Time t = (Time)obj;
            return t.hour == this.hour && t.minute == this.minute && t.second == this.second;
        }
        //fix copy
        public void Copy(Time t)
        {
            this.hour = t.hour;
            this.minute = t.minute;
            this.second = t.second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.hour = 19;
            t1.minute = 30;
            t1.second = 0;

            Time t2 = new Time();
            t2.hour = 19;
            t2.minute = 30;
            t2.second = 0;

            //problems with objects
            Console.WriteLine(t1);                               //print does not show data
            //t1==t2 requires advance fix
            if (t1.Equals(t2)) Console.WriteLine("same");        //compare does not look at data
            else Console.WriteLine("different");

            Time t3 = new Time();
            //t3 = t1; requires advance fix
            t3.Copy(t1);
            t1.second = 40;                                     //after a copy, both objects change same data
            Console.WriteLine(t3.second);

            Console.ReadLine();
        }
    }
}
