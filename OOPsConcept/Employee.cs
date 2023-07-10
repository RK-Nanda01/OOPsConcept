using System;
namespace OOPsConcept
{
	public class Employee
	{
		public string name;
        public int age;

		public Employee(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public void GetDeatils()
		{
			Console.WriteLine($"The name of the employee is {this.name} and age is {this.age}");

		}
	}
}

