using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Queue
{
    public class Queue
    {
        private int[] _queueArray;
        private int _front;
        private int _rear;
        private int _size;
        private int _capacity;

        public Queue(int capacity)
        {
            _capacity = capacity;
            _queueArray = new int[_capacity];
            _front = 0;
            _rear = -1;
            _size = 0;
        }

        public void Enqueue(int item)
        {
            if (_size == _capacity)
            {
                Console.WriteLine("Queue is full. ");
                return;
            }
            _rear = (_rear + 1) % _capacity;
            _queueArray[_rear] = item;
            _size++;
            Console.WriteLine($"Enqueued: {item}");
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. ");
            }
            int item = _queueArray[_front];
            _front = (_front + 1) % _capacity;
            _size--;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. ");
            }
            return _queueArray[_front];
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }
    }
}
