using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class PropertiesExample
    {
        private int Number;
        public int ID
        {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return "Patil";
            }
            set
            {
                surname = value;
            }
        }
        public string Name { get; set; }
        public string Address { get; set; } = "Pune";
        public int PrimaryNumber { get; } = 10;

        public Student[] StudentList { get; set; }
        public int[] Numbers { get; set; }
    }

    class UseOfProperites
    {
        public void InitializePropertyExample()
        {
            PropertiesExample myProperties = new PropertiesExample();
            myProperties.Address = "Mumbai";
            myProperties.ID = 1000;

            int[] numbers = new int[5];

            myProperties.Numbers = numbers;

            Student student1 = new Student()
            {
                Address = "Pune",
                ID = 100,
                Name = "Manoj"
            };
            Student student2 = new Student()
            {
                Address = "Pune, 411027",
                ID = 100,
                Name = "Manoj"
            };
            myProperties.StudentList = new Student[5];

            myProperties.StudentList[0] = student1;
            myProperties.StudentList[1] = student2;


            Console.WriteLine(myProperties.Address);
        }
    }
}
