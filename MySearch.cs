using System;

namespace Activity5._1._2
{
    class MySearch : MySort
    {
        public MySearch():base()
        {

        }
        public int BinarySearch(int val, ref int count)
        {
            DataSort();
            int first = 0;
            int last = sz - 1;
            int mid;
            count = 0;
            while(first<=last)
            {
                count++;
                mid = (first + last) / 2;
                if (val == x[mid]) return mid;
                else if (val > x[mid]) first = mid + 1;
                else last = mid - 1;

            }
            return -1;
        }
    }
}