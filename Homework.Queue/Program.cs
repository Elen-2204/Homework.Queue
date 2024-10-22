// See https://aka.ms/new-console-template for more information

using Homework.Queue;

Queue<string> queue = new Queue<string>();

queue.Enqueue("Hello");
queue.Enqueue("World");
queue.Enqueue("Bye");
queue.Enqueue("something");


queue.Dequeue();
queue.Dequeue();


Console.WriteLine(queue.Peek());
