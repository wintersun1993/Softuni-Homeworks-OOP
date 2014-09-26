using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericList<T> where T : IComparable
    {
        private const int CAPACITY = 16;
        private int changable = CAPACITY;
        private T[] list;
        private int added = 0;
        
        public GenericList(int ListL = CAPACITY)
        {
            list = new T[ListL];
        }

        public int ListLng
        { 
            get
            {
                return this.ListLng;
            }
            set
            {
                this.ListLng = value;
            }
        }

        public int Cap
        {
            get
            {
                return this.list.Length;
            }
        }

        public void add(T element)
        {
            if (this.added >= Cap)
            {
                Array.Resize(ref list, Cap * 2);
            }

            this.list[added] = element;
            this.added++;
        }
        
        public T index(int indexelement)
        {
            return this.list[indexelement];
        }

        public T[] remove(int indexel)
        {
            List<T> foos = new List<T>(list);
            foos.RemoveAt(indexel);
            return foos.ToArray();
        }

        public void insert(T element, int position)
        {
            if (position >= Cap)
            {
                Array.Resize(ref list, Cap * 2+position);
            }
            list[position] = element;
        }

        public void clear()
        {
            Array.Clear(list, 0, list.Length);
        }

        public int FindIndex(T SearchedElement)
        {
            int indexfound = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(SearchedElement))
                {
                    indexfound = i;
                }
            }

            return indexfound;
        }

        public bool contains(T CheckElement)
        {
            if (Array.IndexOf(list,CheckElement)!=-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Max()
        {
            T max = this.list[0];
            for (int i = 1; i < list.Length; i++)   
            {
                if (this.list[i].CompareTo(max)>0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public T Min()
        {
            T min = this.list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (this.list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder stringlist= new StringBuilder();
            int count = 0;

            for (int i = 0; i < list.Length; i++)
            {
                stringlist.Append(list[i]);
                if (count < list.Length - 1)
                {
                    stringlist.Append(",");
                }
                count++;
            }

            return stringlist.ToString();
        }
    }
}
