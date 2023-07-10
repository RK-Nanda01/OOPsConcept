using System;
namespace OOPsConcept
{
	public class Employee
	{
		private
			string name;
			int age;

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

