using System;
using System.Collections.Generic;

namespace GradesList
{
    class Student
    {
        public string name
        {
            get; set;
        }
        public int age
        {
            get;
            set;
        }
        public int Math
        {
            get;
            set;
        }
        public int Science
        {
            get;
            set;
        }
        public int SocialStudies
        {
            get;
            set;
        }
        public int English
        {
            get;
            set;
        }
        public int Art
        {
            get;
            set;
        }
    } //Eof

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                name = "Mary",
                age = 15,
                Math = 60,
                Science = 95,
                SocialStudies = 100,
                English = 82,
                Art = 95
            };
            Student s2 = new Student()
            {
                name = "Harold",
                age = 12,
                Math = 88,
                Science = 75,
                SocialStudies = 997,
                English = 100,
                Art = 100,
            };
            Student s3 = new Student()
            {
                name = "Mark",
                age = 17,
                Math = 80,
                Science = 97,
                SocialStudies = 99,
                English = 85,
                Art = 90,
            };
            Student s4 = new Student()
            {
                name = "Rosa",
                age = 15,
                Math = 78,
                Science = 80,
                SocialStudies = 98,
                English = 70,
                Art = 100
            };

            Student s5 = new Student()
            {
                name = "Lean",
                age = 16,
                Math = 90,
                Science = 86,
                SocialStudies = 60,
                English = 82,
                Art = 100,
            };

            List<Student> Student = new List<Student>();
            Student.Add(s1);
            Student.Add(s2);
            Student.Add(s3);
            Student.Add(s4);
            Student.Add(s5);

            Console.WriteLine("Student List");

            Console.WriteLine("Name={0}, age ={1}, math = {2}, Science = {3}, Social Studies={4}, English={5}, art = {6}",
                s1.name, s1.age, s1.Math, s1.Science, s1.SocialStudies, s1.English, s1.Art);     //Student 1
            Console.WriteLine("Name={0}, age ={1}, math = {2}, Science = {3}, Social Studies={4}, English={5}, art = {6}",
                s2.name, s2.age, s1.Math, s2.Science, s2.SocialStudies, s2.English, s2.Art);     //Student 2
            Console.WriteLine("Name={0}, age ={1}, math = {2}, Science = {3}, Social Studies={4}, English={5}, art = {6}",
                s3.name, s3.age, s3.Math, s3.Science, s3.SocialStudies, s3.English, s3.Art);     //Student 3
            Console.WriteLine("Name={0}, age ={1}, math = {2}, Science = {3}, Social Studies={4}, English={5}, art = {6}",
                s4.name, s4.age, s4.Math, s4.Science, s4.SocialStudies, s4.English, s4.Art);     //Student 4
            Console.WriteLine("Name={0}, age ={1}, math = {2}, Science = {3}, Social Studies={4}, English={5}, art = {6}",
                s5.name, s5.age, s5.Math, s5.Science, s5.SocialStudies, s5.English, s5.Art);     //Student 5

            
        }//EofC
    }//EofN

}          
    

