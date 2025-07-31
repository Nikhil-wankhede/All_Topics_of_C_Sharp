using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class ListExample
    {
        public void InitializeListExample()
        {
            List<int> NumberCollection = new List<int>();

            for (int i = 10; i < 21; i++)
            {
                NumberCollection.Add(i);
            }
            NumberCollection.Add(int.Parse("30"));


            List<string> strings = new List<string>();

            List<string> obj = new List<string>()
            {
                "Manoj 1",
                "Manoj 2",
                "Manoj 3",
                "Manoj 4"
            };

            Student student1, student2, student3, student4;
            GetStudentRecord(out student1, out student2, out student3, out student4);

            List<Student> studentList = new List<Student>()
            {
                student1, student2, student3, student4
            };

            //studentList.Add(student1);
            //studentList.Add(student2);
            //studentList.Add(student3);
            //studentList.Add(student4);

            var filteredList = studentList.Where(p => p.ID == 100).ToList();




            foreach (Student student in studentList)
            {
                Console.WriteLine(student.ID + ", " + student.Name);
            }



        }

        public static void GetStudentRecord(out Student student1, out Student student2, out Student student3, out Student student4)
        {
            student1 = new Student();
            student1.Name = "Manoj";
            student1.ID = 100;

            student2 = new Student();
            student2.Name = "Ganesh";
            student2.ID = 200;

            student3 = new Student();
            student3.Name = "Ram";
            student3.ID = 300;

            student4 = new Student();
            student4.Name = "Rakesh";
            student4.ID = 400;
        }

        public static List<Student> GetStudentRecord()
        {
            Student student1, student2, student3, student4;
            List<Student> studentList = new List<Student>();
            student1 = new Student();
            student1.Name = "Manoj";
            student1.ID = 100;

            student2 = new Student();
            student2.Name = "Ganesh";
            student2.ID = 300;

            student3 = new Student();
            student3.Name = "Ram";
            student3.ID = 100;

            student4 = new Student();
            student4.Name = "Rakesh";
            student4.ID = 300;
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);

            return studentList;
        }
    }
}
