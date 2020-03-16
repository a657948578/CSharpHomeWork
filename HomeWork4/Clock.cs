using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{

    public delegate void ClockHandler();
    public delegate void AlarmHandler();

    class Clock
    {
        public int h;
        public int m;
        public int s;

        public event AlarmHandler TimeEvent;
        public event ClockHandler TickEvent;
        public event ClockHandler TockEvent;

        private static int Hou { get; set; }
        private static int Min { get; set; }
        private static int Sec { get; set; }

        public Clock(int h, int m, int s)
        {
            Sec = 0;
            Min = 0;
            Hou = 0;
            this.s = s;
            this.m = m;
            this.h = h;
            TickEvent += Tick;
            TockEvent += Tock;
            TimeEvent += alarm;
        }

        void Tick() { 
            Console.WriteLine("Tick"); 
        }
        void Tock() { 
            Console.WriteLine("Tock"); 
        }
        void alarm() { 
            Console.WriteLine("Time"); 
        }

        public void Start()
        {
            while (Hou != h || Min != m || Sec + 1 != s)
            {
                Sec += 1;
                if (Sec == 60 && Min != 60)
                {
                    Min += 1;
                    Sec = 0;
                    TockEvent();
                    Thread.Sleep(1000);
                    continue;
                }
                if (Min == 60 && Sec == 60)
                {
                    Hou += 1;
                    Sec = Min = 0;
                    TockEvent();
                    Thread.Sleep(1000);
                    continue;
                }
                TickEvent();
                Thread.Sleep(1000);
            }
            TimeEvent();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(0, 0, 0);
            clock.Start();
            Console.ReadKey();
        }
    }
}
