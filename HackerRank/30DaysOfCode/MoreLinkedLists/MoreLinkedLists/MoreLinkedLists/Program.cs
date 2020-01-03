using System;
using System.Collections.Generic;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{

    public static Node removeDuplicates(Node head)
    {
        //Write your code here
        // 1 2 2 3 4 4 5
        // 1 1 1 1 1 1 1
        if (head.next == null)
            return head;
        var currentNode = head;
        while (currentNode.next!=null)
        {
            while(currentNode.data==currentNode.next.data)
            {
                if (currentNode.next.next == null)
                {
                    currentNode.next = null;
                    break;
                }
                else
                    currentNode.next = currentNode.next.next;
            }
            if(currentNode.next!=null)
            currentNode = currentNode.next;
        }
        return head;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);


        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }
    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        head = removeDuplicates(head);
        display(head);
    }
}
