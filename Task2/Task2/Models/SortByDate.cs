using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class SortByDate
    {
        public static void Quicksort(Post[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            Post pivot = arr[left + (right - left) / 2];

            while (i <= j)
            {
                while (arr[i].Date.CompareTo(pivot.Date) < 0)
                    i++;

                while (arr[j].Date.CompareTo(pivot.Date) > 0)
                    j--;

                if (i <= j)
                {
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(arr, left, j);

            if (i < right)
                Quicksort(arr, i, right);
        }
    }
}
