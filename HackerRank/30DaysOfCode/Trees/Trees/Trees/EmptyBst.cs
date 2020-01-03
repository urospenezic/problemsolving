using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class EmptyBst<T> : ITree<T> where T:IComparable
    {
        public EmptyBst()
        {

        }
        public NonEmptyBSTree<T> Add(T element)
        {
            return new NonEmptyBSTree<T>(element);
        }

        public int Cardinality()
        {
            return 0;
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return true;
        }

        public bool Member(T element)
        {
            return false;
        }
    }
}
