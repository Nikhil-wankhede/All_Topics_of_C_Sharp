using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class SortedListExample
    {
        public void InitializeSortedListExample()
        {
            SortedList objSortedList = new SortedList();
            objSortedList.Add(100, new Student());
            objSortedList.Add(200, "test");

            SortedList<int, string> genericSortedList = new SortedList<int, string>();
            genericSortedList.Add(10, "Nikhil");
            genericSortedList.Add(20, "Wankhede");

            var record = genericSortedList[20];
            genericSortedList.IndexOfKey(20);

            genericSortedList.Where(x => x.Key.Equals(20)).FirstOrDefault();
            
            if (genericSortedList.ContainsKey(20))
            {
                record = genericSortedList[20];
            }

        }
    }
}
