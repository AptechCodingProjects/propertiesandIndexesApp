using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesandIndexesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate c = new Calculate();

            //Console.WriteLine(c.readBalance);
            //c.writeBalance = 50000;

            //Console.WriteLine(c.readBalance);

            //Console.ReadKey();

            List<Student> students = new List<Student>();

            students.Add(new Student { enrolmentId = 1, name = "Fahad" });
            students.Add(new Student { enrolmentId = 2, name = "Huzaifa" });
            students.Add(new Student { enrolmentId = 3, name = "Javed" });
            students.Add(new Student { enrolmentId = 4, name = "Hamza" });
            students.Add(new Student { enrolmentId = 5, name = "Hyder" });
            students.Add(new Student { enrolmentId = 6, name = "Tufail" });
            students.Add(new Student { enrolmentId = 7, name = "Zeeshan" });
            students.Add(new Student { enrolmentId = 8, name = "Mohsin" });

            foreach (Student student in students)
            {
                Console.WriteLine("Enrollment Ids: {0}",student.enrolmentId);
                Console.WriteLine("Name: {0}\n",student.name);
            }

            Console.ReadKey();
        }
    }
}
