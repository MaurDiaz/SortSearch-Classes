using System;

namespace Activity5._1._2
{
    class MySort
    {
        protected int[] x = new int[1000000];
        protected int sz;
        public bool Sorted { get; private set; }
        public MySort()
        {
            this.sz = 0;
            this.Sorted = false;
        }
        public void AddItem(int val)
        {
            
            this.Sorted = false;
        }
        public void AddRandomItems(int n) 
        {
            //ToDo
            this.Sorted = false;
        }
        public void InsertionSort(int[] x, int n)
        {
            //ToDo
        }
        public void DataSort()
        {
            if (this.Sorted == false)
            {
                InsertionSort(x, sz);
                this.Sorted = true;
            }
        }
        public void ShowArray()
        {
            Console.WriteLine("Sorted Array Elements: ");
            for (int i = 0; i < this.sz; i++)
            {
                Console.Write(this.x[i] + " ");
            }
        }
    }
}