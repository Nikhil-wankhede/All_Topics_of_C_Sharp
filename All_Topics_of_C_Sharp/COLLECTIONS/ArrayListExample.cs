using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class ArrayListExample
    {
        public void InitializeArrayListExample()
        {
            ArrayList myList = new ArrayList();
           
            myList.Add(100);
            myList.Add("Nikhil");
            myList.Add(true);
            Student student = new Student()
            {
                Name = "Nikhil",
                ID = 400
            };
            myList.Add(student);

            myList.Add(new Student() { Name = "Wankhede", ID = 400 });

            int[] Numbers = new int[5];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i + 10;
            }

            myList.Add(Numbers);
            myList.AddRange(Numbers);
            if (myList.Contains("Nikhil"))
            {
                
            }
            else
            {

            }
            myList.Insert(5, "This is new Element added");
            myList.Remove(11); //Removing the value - 11
            myList.RemoveAt(6); // Removing the value at 6th Index
            var dynamicArray = myList.ToArray();
        }
    }
}
