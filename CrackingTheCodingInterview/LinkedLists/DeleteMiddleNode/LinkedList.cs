using System;
namespace DeleteMiddleNode
{
    public class LinkedListNode
    {
        public int Data { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int data)
        {
            Data=data;
            Next= null;
        }
    }
    public class LinkedList
    {
        public LinkedListNode Head { get; set; }
        public void AddToTail(int data)
        {
            var end= new LinkedListNode(data);
            var current= Head;
            if(Head==null)
            Head=end;
            else{
            while (current.Next!=null)
            {
                current= current.Next;
            }
            current.Next= end;
            }
        }
        public LinkedListNode DeleteNode(int d)
        {
            var current = Head;
            if(current.Data==d)
            return current.Next;
            while (current.Next!=null)
            {
                if(current.Next.Data==d)
                {
                    current.Next=current.Next.Next;
                    return Head;
                }
                current= current.Next;
            }
            return Head;
        }
    }
}