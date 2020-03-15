using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    //声明委托格式
    public delegate void ClockSoundHandler();
    public delegate void AlarmHandler();

    class Clock
    {
        //定义事件
        public event ClockSoundHandler TickEvent;
        public event ClockSoundHandler TockEvent;
        public event AlarmHandler TimeUpEvent;

        //时钟时间
        private static int Sec { get; set; }
        private static int Min { get; set; }
        private static int Hour { get; set; }
        //响铃时间
        public int s;
        public int m;
        public int h;
        //构造函数
        public Clock(int h, int m, int s)
        {
            Sec = 0;
            Min = 0;
            Hour = 0;
            this.s = s;
            this.m = m;
            this.h = h;
            TickEvent += onTick;
            TockEvent += onTock;
            TimeUpEvent += alarm;
        }

        void onTick() { Console.WriteLine("~~~~~~~Tick~~~~~~~"); }
        void onTock() { Console.WriteLine("~~~~~~~Tock~~~~~~~"); }
        void alarm() { Console.WriteLine("-----Time's Up-----"); }

        public void StartWork()
        {
            while (Sec + 1 != s || Min != m || Hour != h)
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
                else if (Sec == 60 && Min == 60)
                {
                    Hour += 1;
                    Sec = Min = 0;
                    TockEvent();
                    Thread.Sleep(1000);
                    continue;
                }
                TickEvent();
                Thread.Sleep(1000);
            }
            TimeUpEvent();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock(0, 0, 5);
            clock1.StartWork();
            Console.ReadKey();
        }
    }
}
