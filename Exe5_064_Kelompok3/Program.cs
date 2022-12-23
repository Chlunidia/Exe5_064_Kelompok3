using System;

namespace QueueLinkedList
{
    // A linked list (LL) node to store a queue entry
    class QNode
    {
        // Create variable key and next
        public string key;
        public QNode next;
        // constructor to create a new linked list node
        public QNode(string key)
        {
            this.key = key;
            this.next = null;
        }
    }
    // A class to represent a queue. The queue, chlunidia stores the chlunidia node of LL and rear stores the last node of LL
    class Queue
    {
        public QNode chlunidia, rear;
        public Queue() 
        { 
            this.chlunidia = this.rear = null; 
        }
        // Method to add an key to the queue.
        public void enqueue(string key)
        {
            // Create a new LL node
            QNode temp = new QNode(key);
            // If queue is empty, then new node is chlunidia and rear both
            if (this.rear == null)
            {
                Console.Write(key + " is inserted to queue.");
                Console.WriteLine();
                this.chlunidia = this.rear = temp;
                return;
            }
            else
            {
                Console.WriteLine("Please enter an element!");
            }
            // Add the new node at the end of queue and change rear
            Console.Write(key + " is inserted to queue.");
            Console.WriteLine();
            this.rear.next = temp;
            this.rear = temp;
        }
    }
}