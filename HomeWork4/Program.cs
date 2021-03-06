﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9_1_
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> temp = head;
            while (temp.Next != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
            action(temp.Data);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> list = new GenericList<int>();
            //赋值
            for (int x = 0; x < 50; x++)
            {
                list.Add(x);
            }
            //输出所有元素
            Console.WriteLine("输出所有元素：");
            list.ForEach(i => Console.WriteLine(i));
            //max
            Console.WriteLine("max:");
            int max = 0;
            list.ForEach(delegate (int i) { max = max < i ? i : max; });
            Console.WriteLine(max);
            //sum
            Console.WriteLine("sum:");
            int sum = 0;
            list.ForEach(i => sum += i);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}