using System.Collections.Generic
namespace GradeBook 
{
    class Book 
    {
        private List<double> grades;
        public string name;

        public Book(string name)
        {
           this.grades = new List<double>();
           this.name = name;

        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }
    }
}