using System;
using System.Collections.Generic;

namespace _37.CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> print = Console.WriteLine;

            var cQueue = new CQueue<int>(10);
            cQueue.Enqueue(10);
            cQueue.Enqueue(20);
            cQueue.Enqueue(30);
            cQueue.Enqueue(40);
            cQueue.Enqueue(50);
            cQueue.Enqueue(60);
            cQueue.Enqueue(70);
            cQueue.Enqueue(80);
            cQueue.Enqueue(90);
            cQueue.Enqueue(100);
            // cQueue.Enqueue(110);
            print(cQueue.Count() == 10);
            print(cQueue.Dequeue() == 10);
            print(cQueue.Dequeue() == 20);
            print(cQueue.Dequeue() == 30);
            print(cQueue.Dequeue() == 40);
            print(cQueue.Dequeue() == 50);
            print(cQueue.Dequeue() == 60);
            print(cQueue.Dequeue() == 70);
            print(cQueue.Dequeue() == 80);
            print(cQueue.Dequeue() == 90);
            print(cQueue.Dequeue() == 100);
            // print(cQueue.Dequeue());
            print(cQueue.Count() == 0);
        }
    }
    public class CQueue<T>
    {
        int head = 0;
        int tail = 0;
        int count = 0;
        T[] arr;
        public CQueue(int size)
        {
            head = 0;
            tail = 0;
            arr = new T[size];
        }
        public void Enqueue(T t)
        {
            arr[tail] = t;
            tail++;
            count++;
        }
        public T Dequeue()
        {
            T temp = arr[head];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            count--;
            return temp;
        }
        public int Count()
        {
            return count;
        }
    }
}
