using System;

namespace BinarySearchTree
{
    public class BinaryTreeNode
    {
        public int Data { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode Parent { get; set; }
        public int Size { get; private set; }
        public BinaryTreeNode(int data)
        {
            Data=data;
            Size=1;
        }
        public void AddInOrder(int d)
        {
            if(d<=Data)
            {
                if(Left==null)
                SetLeftChild(new BinaryTreeNode(d));
                else
                Left.AddInOrder(d);
            }
            else
            {
                if(Right==null)
                SetRightChild(new BinaryTreeNode(d));
                else
                Right.AddInOrder(d);
            }
            Size++;
        }
        private void SetRightChild(BinaryTreeNode binaryTreeNode)
        {
            Right= binaryTreeNode;
            if(binaryTreeNode!=null)
            binaryTreeNode.Parent=this;
        }

        private void SetLeftChild(BinaryTreeNode binaryTreeNode)
        {
            Left= binaryTreeNode;
            if(binaryTreeNode!=null)
            binaryTreeNode.Parent= this;
        }
        public BinaryTreeNode Find(int data)
        {
            if(data==Data)
            return this;
            else if (data<=Data)
            return Left!=null ? Left.Find(data) : null;
            else if(data>Data)
            return Right!=null ? Right.Find(data) : null;

            return null;
        }
    }
}
