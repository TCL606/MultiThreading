using System;
using System.Threading;

namespace Homework1
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.Test();
        }
        public void Test()
        {
            new Thread(Consume).Start();
            Thread.Sleep(100);
            new Thread(Produce).Start();
            Console.WriteLine(cake.Error);
        }

        public Cake cake = new Cake(0);
        public void P(Semaphore sema) => sema.WaitOne();
        public void V(Semaphore sema) => sema.Release();

// ================================================================================================================       

        // 题目：现在有一个消费者，一个生产者。消费者生产一个蛋糕，消费者消费一个蛋糕。
        //       初始时没有蛋糕。两个线程开始的时间不确定。

        // 要求：保证消费者消费蛋糕时，生产者已经把蛋糕生产好了

        // 修改范围内的代码，允许添加字段或者属性或者方法，使程序满足要求
        
        // 提示：使用定义好的 P函数 与 V函数


        //添加信号量，当前为0，不能在一开始锁（consume）
        //临界区资源就是cake
        //相当于sema与Cake数量挂钩,同时在Comsume前面检测是否有cake.

        public Semaphore sema = new Semaphore(0, int.MaxValue); //可能会一直生产蛋糕

        public void Produce()
        {
            //临界区
            Producer.ProduceACake(cake); 
            V(sema);
        }

        public void Consume()
        {
            //临界区
            P(sema);
            Consumer.ConsumeACake(cake);
        }
        
// ==================================================================================================================  
    }

    public class Cake
    {
        private int num;
        public int Num 
        { 
            get
            {
                if (num <= 0)
                {
                    this.Error = true;
                    return num;
                }
                return num;
            }
        }

        public void AddNum() => this.num++;

        public void SubNum() => this.num--;

        public bool Error { get; private set; }

        public Cake(int num)
        {
            this.num = num;
            Error = false;
        }
    }

    public class Producer
    {
        public static void ProduceACake(Cake cake)
        {
            cake.AddNum();
        }
    }

    public class Consumer
    {
        public static void ConsumeACake(Cake cake)
        {
            Console.WriteLine($"I get a cake. Now cake number is {cake.Num}");
            cake.SubNum();
        }
    }
}