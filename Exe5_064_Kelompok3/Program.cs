﻿using System;

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
    // A class to represent a queue. The queue, chlunidia stores the chlunidia node of LL and kieswendha stores the last node of LL
    class Queue
    {
        public QNode chlunidia, kieswendha;
        public Queue() 
        { 
            this.chlunidia = this.kieswendha = null; 
        }        
    }
}