using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Models
{
    internal class Person
    {
		private string _name;

		public string Name
		{
			get 
			{ 
				return _name; 
			}
			set 
			{ 
				if(value.Length > 3)
				{
					_name = value;
				} 
			}
		}

		private string _surname;

		public string Surname
		{
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 6)
                {
                    _surname = value;
                }
            }
        }

		private byte _age;

		public byte Age
		{
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, string surname, byte age)
        {
			Name = name;
			Surname = surname;
			Age = age;
        }

		public override string ToString()
		{
			return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
		}
    }
}
