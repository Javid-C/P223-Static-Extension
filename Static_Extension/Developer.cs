using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	class Developer
	{
		public static int count;
		public string Profession;
		public double Salary;

		

		static Developer()
		{
			count++;
		}


		public void ShowInfo()
		{
			Console.WriteLine($"{Profession} {Salary}");
		}

		public bool CheckSalary(double salary)
		{
			if (salary < 0)
			{
				return false;
			}
			return true;
		}
	}
}
