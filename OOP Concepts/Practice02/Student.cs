using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    class Student : Person
    {
        public Student()
        { }

        // Constructor chaining
        // Constructor zincirleme çağırma
        public Student(string firstName, string lastName)
        : this(firstName, lastName, default)
        {
            // FirstName ve LastName atama işlemlerini 3 parametreli
            // constructor metoda devrettiğim için benim bu işi yapmama
            // gerek kalmadı
            //FirstName = firstName;
            //LastName = lastName;
        }

        public Student(string firstName, string lastName, int studentNumber)
            // :this(firstName, lastName) şeklinde bir üstte yer alan constructor da
            // çağırılabilir
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
        }

        public int StudentNumber { get; set; }
        public string CourseName { get; set; }
        public int GraduateYear { get; set; }
    }
}
