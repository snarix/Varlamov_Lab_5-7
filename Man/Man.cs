using System;

namespace Mans
{
    public class Man
    {
        protected string _name;
        protected int _age;
        protected string _gender;
        protected int _weight;

        public Man(string name, int age, string gender, int weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _weight = weight;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public int Age 
        {
            get => _age;
            set
            {
                _age = value;
            }
        }
        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
            }
        }
        public int Weight 
        {
            get => _weight;
            set
            {
                _weight = value;
            }
        }

        public void SetParams(string value1, int value2, string value3, int value4)
        {
            Name = value1;
            Age = value2;
            Gender = value3;
            Weight = value4;
        }

        public void SetParams()
        {
            Name = "John";
            Age = 18;
            Gender = "Male";
            Weight = 65;
        }

        public static Man operator ++(Man age)
        {
            Man result = new Man("John", 18, "Male", 65);
            result.Age = age.Age + 1;
            return result;
        }

        public static bool operator >(Man weight, Man weight2)
        {
            if (weight.Weight > weight2.Weight)
                return true;
            else
                return false;
        }

        public static bool operator <(Man weight, Man weight2)
        {
            if (weight.Weight < weight2.Weight)
                return true;
            else
                return false;
        }

    }
}
