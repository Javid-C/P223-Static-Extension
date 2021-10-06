using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	class Student
	{
		public static int count = 1;
		public int Id;
		public string Name;
		public string Surname;
		public string Group;

		public Student(string name,string surname,string group)
		{
			Id=count;
			Name = name;
			Surname = surname;
			Group = group;
			count++;
		}
	}
}
