// See https://aka.ms/new-console-template for more information

PrintName();
AvgNumber();
Area();

//task 1
static void PrintName()
{
    Console.WriteLine("Enter your Name");
    string name =Console.ReadLine();
    Console.WriteLine($"Your name is {name}");
}

//task 2
 void AvgNumber()
{
    Console.WriteLine("Enter first number:");
       int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third number:");
  int number3 = Convert.ToInt32(Console.ReadLine());
    double avg =Convert.ToDouble((number1 + number2 + number3)/3);
    Console.WriteLine($"Average of numbers are :{avg}");
}

//Task 3
 void Area()
{
    Console.WriteLine("Enter radius of circle:");
    int r = Convert.ToInt32(Console.ReadLine());
    double A = Math.PI * (r * r);
    Console.WriteLine($"Area of circle is {A}");
}

Console.ReadKey();
   

