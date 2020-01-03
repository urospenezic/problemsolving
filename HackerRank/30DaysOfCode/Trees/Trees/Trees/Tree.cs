using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
   public interface ITree<T> where T:IComparable
    {
        bool IsEmpty();
        int Cardinality();
        bool Member(T element);
        NonEmptyBSTree<T> Add(T element);
    }
}
