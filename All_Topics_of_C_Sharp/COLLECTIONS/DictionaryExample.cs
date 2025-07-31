using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    public class DictionaryExample
    {
        public void InitializeDictionryExample()
        {
            Student student1, student2, student3, student4;
            ListExample.GetStudentRecord(out student1, out student2, out student3, out student4);

            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            studentDictionary.Add(student1.ID, student1);
            studentDictionary.Add(student2.ID, student2);
            studentDictionary.Add(student3.ID, student3);
            studentDictionary.Add(student4.ID, student4);

            Student student5 = new Student() { ID = 500, Name = "Tushar" };
            studentDictionary.Add(student5.ID, student5);

            Dictionary<string, Student> studentDictionaryByName = new Dictionary<string, Student>();
            studentDictionaryByName.Add(student1.Name, student1);
            studentDictionaryByName.Add(student2.Name, student2);
            studentDictionaryByName.Add(student3.Name, student3);
            studentDictionaryByName.Add(student4.Name, student4);

            var selectedStudent = studentDictionary[300];

            string name = "Manoj";
            if (!string.IsNullOrEmpty(name))
            {
                var selectStudentByName = studentDictionaryByName[name];
                
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                var selectStudentByName = studentDictionaryByName[name];
            }


            if (studentDictionary.ContainsKey(100))
            {

            }

            var result = studentDictionary.Where(x => x.Value.Name == "Manoj").ToList();

            foreach (var student in studentDictionaryByName)
            {
                Console.WriteLine("Student Name : " + student.Value.Name);
                Console.WriteLine("Student ID : " + student.Value.ID);
            }

            foreach (var student in result)
            {
                Console.WriteLine("Searched Student ID : " + student.Key);
                Console.WriteLine("Searched Student Name : " + student.Value.Name);

            }


            //Get records from Value object directly
            foreach (var item in studentDictionary.Values)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.Name);
                }
            }


            Dictionary<int, int> myList = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i + 1, i + 10); // 1, 11      2,12
            }

            if (myList.ContainsValue(15))
            {

            }

        }
    }
}
