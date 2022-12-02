using System;
using Mans;

namespace Students
{
    public class Student : Man
    {
        protected string _faculty;
        protected int _course;
        protected int _group;

        public Student(string name, int age, string gender, int weight, string faculty, int course, int group) : base(name, age, gender, weight)
        {
            _faculty = faculty;
            _course = course;
            _group = group;
        }

        public string Faculty
        {
            get => _faculty;
            set
            {
                _faculty = value;
            }
        }

        public int Course
        {
            get => _course;
            set
            {
                _course = value;
            }
        }

        public int Group
        {
            get => _group;
            set
            {
                _group = value;
            }
        }

        public void SetParam(string value1, int value2, int value3)
        {
            Faculty = value1;
            Course = value2;
            Group = value3;
        }

        public static Student operator ++(Student course)
        {
            
            course.Course = course.Course + 1;
            return course;
        }

        public static Student operator --(Student group)
        {          
            group.Group = group.Group - 1;
            return group;
        }
    }
}
