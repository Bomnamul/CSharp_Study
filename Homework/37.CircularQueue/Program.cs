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
            cQueue.Enqueue(110);
            print(cQueue.Count() == 9);
            print(cQueue.Dequeue() == 10);
            print(cQueue.Dequeue() == 20);
            print(cQueue.Dequeue() == 30);
            print(cQueue.Dequeue() == 40);
            print(cQueue.Dequeue() == 50);
            print(cQueue.Dequeue() == 60);
            print(cQueue.Dequeue() == 70);
            print(cQueue.Dequeue() == 80);
            print(cQueue.Dequeue() == 90);
            print(cQueue.Count() == 0);
            print(cQueue.Dequeue() == 0);
            print(cQueue.Count() == 0);
        }
    }
    public class CQueue<T>
    {
        int front;
        int rear;
        int count = 0;
        T[] arr;
        public CQueue(int size)
        {
            front = 0;
            rear = 0;
            arr = new T[size];
        }
        public void Enqueue(T t)
        {
            if ((rear + 1) % arr.Length == front)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            arr[rear] = t;
            rear = (rear % arr.Length) + 1;
            count++;
        }
        public T Dequeue()
        {
            if (front == rear)
            {
                return default(T);
            }
            T temp = arr[front];
            front = (front % arr.Length) + 1;
            count--;
            return temp;
        }
        public int Count()
        {
            return count;
        }
    }
}
