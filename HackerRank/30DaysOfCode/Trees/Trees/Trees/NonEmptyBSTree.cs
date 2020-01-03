using System;

namespace Trees
{
    public class NonEmptyBSTree<T> : ITree<T> where T : IComparable
    {
        public T Data { get; set; }
        public ITree<T> Left { get; set; }
        public ITree<T> Right { get; set; }

        public NonEmptyBSTree(T element)
        {
            Data = element;
            Left = new EmptyBst<T>();
            Right = new EmptyBst<T>();
        }

        public NonEmptyBSTree(T element, ITree<T> left, ITree<T> right)
        {
            Data = element;
            Left = left;
            Right = right;
        }

        public NonEmptyBSTree<T> Add(T element)
        {
            if (element.CompareTo(Data) == 0)
                return this;
            else
            {
                if (element.CompareTo(Data) < 0)
                    return new NonEmptyBSTree<T>(element, Left.Add(element),Right);
                else
                    return new NonEmptyBSTree<T>(element, Left, Right.Add(element));
            }
        }

        public int Cardinality()
        {
            return 1 + Left.Cardinality() + Right.Cardinality();
        }

        public bool IsEmpty()
        {
            return false;
        }

        public bool Member(T element)
        {
            if (element.CompareTo(Data) == 0)
                return true;
            else
            {
                if (element.CompareTo(Data) < 0)
                    return Left.Member(element);
                else
                    return Right.Member(element);
            }
        }
    }
}