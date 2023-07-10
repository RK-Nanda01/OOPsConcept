namespace OOPsConcept;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("OOPS Concept");
        Employee e1 = new Employee("RAMAN" , 32);        
        e1.GetDeatils();
        Manager m1 = new Manager("Suresh", 39, 120392);
        m1.GetManagerDetails();

    }
}

