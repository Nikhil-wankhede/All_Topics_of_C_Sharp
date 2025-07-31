using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class HashTableExample
    {
        public void InitializeHashTableExample()
        {
            Student student1, student2, student3, student4;
            ListExample.GetStudentRecord(out student1, out student2, out student3, out student4);

            Hashtable objHash = new Hashtable();
            objHash.Add(student1.ID, student1);
            objHash.Add(student2.ID, student2);
            objHash.Add(student3.ID, student3);
            objHash.Add(student4.ID, student4);

            foreach (object hash in objHash.Values)
            {
                var student = (Student)hash;
                Console.WriteLine(student.ID);
                Console.WriteLine(student.Name);
            }

        }
    }
}
