using System;

namespace Static_Extension
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Classwork
			//MainPrintFile excel = new MainPrintFile(new Excel());
			//MainPrintFile word = new MainPrintFile(new Word());
			//MainPrintFile pdf = new MainPrintFile(new PDF());


			//Student student1 = new Student("Hikmet","Veliyev","400");
			//Student student2 = new Student("Hikmet1","Veliyev1","400");
			//Student student3 = new Student("Hikmet2","Veliyev2","200");
			//Console.WriteLine(Student.count);

			#endregion

			//People stu;
			//stu.Grade = 80;

			//Menu menu1 = new Menu(Category.Xalodni);
			//Menu menu2 = new Menu(Category.Drink);
			//Menu menu3 = new Menu(Category.Meal);
			//Menu menu4 = new Menu(Category.Desert);

			//Console.WriteLine(menu1.Category);
			//Console.WriteLine(menu2.Category);
			//Console.WriteLine(menu3.Category);
			//Console.WriteLine(menu4.Category);

			//Console.WriteLine((int)Category.Drink);


			Developer developer = new Developer();
			developer.Salary = 5000;
			developer.Profession = "Back-End";
			developer.ShowInfo();
			Developer developer1 = new Developer();
			developer1.Salary = -3000;
			developer1.Profession = "Front-End";
			developer1.ShowInfo();

			//Console.WriteLine(Developer.CheckSalary(developer.Salary));
			//Console.WriteLine(Developer.CheckSalary(developer1.Salary));

			//Console.WriteLine(developer1.CheckSalary(developer.Salary));

			string str = "hello world how are you";

			string heloo = "test";
			//Console.WriteLine(str.Contains('f'));
			Console.WriteLine(str.CustomContain('h'));

			Console.WriteLine(heloo.CustomContain('t'));

			Console.WriteLine(str.Capitalized());
		}
	}

	struct People
	{
		public int Age;
		public int Grade;
		public double test;

		//public Student(int age,int grade)
		//{
		//	Age = age;
		//}
	}

	class School
	{
		public string Name;
		public void ShowInfo()
		{
			Console.WriteLine("School name");
		}

		public virtual void GetPaid()
		{
			Console.WriteLine("Paid");
		}
	}

	class Teacher:School
	{
		public sealed override void GetPaid()
		{
			Console.WriteLine("2000$");
		}
	}
	class Assistant:Teacher
	{
		//public sealed override void GetPaid()
		//{
		//	Console.WriteLine("2000$");
		//}
	}
}
