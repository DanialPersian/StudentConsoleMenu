using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Student
{
    internal class StudentMenuItem : MenuItem
    {
        private Student _student;
        public StudentMenuItem(Student student)
        {
            _student = student;
        }
        public override string MenuText()
        {
            return $"Student : {_student.Name}";
        }

        public override void Select()
        {
            Console.WriteLine("Enter new name");
            _student.Name = Console.ReadLine();
        }
    }
}
