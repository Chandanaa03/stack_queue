﻿using System;
using System.Collections.Generic;

namespace stackdemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            

           
              Queue<int> queue = new Queue<int>();

                queue.Enqueue(56);
                queue.Enqueue(30);
                queue.Enqueue(70);
                

                foreach (int element in queue)
                {
                    Console.WriteLine(element);
                }
           
            Console.WriteLine("peek value is " + queue.Peek());

            //Console.WriteLine("--------------");
            //queue.Dequeue();
            //foreach (int element in queue)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.WriteLine("peek value is " + queue.Peek());
            //Console.WriteLine("--------------");

            //queue.Dequeue();
            //foreach (int element in queue)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.WriteLine("peek value is " + queue.Peek());







        }
    }
}