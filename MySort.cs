using System;

namespace Activity5._1._2
{
    class MySort
    {
        protected int[] x = new int[1000000];
        protected int sz;
        public bool Sorted { get; private set; }

        protected Random r = new Random((int)DateTime.Now.Ticks);
        public MySort()
        {
            this.sz = 0;
            this.Sorted = false;
        }
        public void AddItem(int val)
        {
            for(int i = 0; i <= this.x.Length; i++)
            {
                if (this.x[i] == 0)
                {
                    this.x[i] = val;
                    break;
                }
            }
            this.Sorted = false;
        }
        public void AddRandomItems(int n) 
        {
            for(int i = 1; i <= n; i++)
            {
                AddItem(r.Next(1,1000000));
            }
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