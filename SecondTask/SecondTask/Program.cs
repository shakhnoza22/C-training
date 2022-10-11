// See https://aka.ms/new-console-template for more information

Findday();
Number();
Hours();

static void Findday()
{
    Console.WriteLine("Task-1");
    Console.WriteLine("Enter number of weeks:");
    int week = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number of months:");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number of year:");
    int year = Convert.ToInt32(Console.ReadLine());

    int day = (week * 7) + (month * 30) + (year * 360);
    Console.WriteLine($"Total days are : {day} ");
}
  
static void Number()
{
    Console.WriteLine("Task-2");
    Console.WriteLine("Enter a two-digit number:");
    int num = Convert.ToInt32(Console.ReadLine());
    int n2 = num / 10;
    int n1 = num % 10;
    Console.WriteLine($"{num} opposed is :{n1}{n2}");
}

static void Hours()
{
    Console.WriteLine("Task-3");
    Console.WriteLine("Enter number of secunds");
 int secund = Convert.ToInt32(Console.ReadLine());
    int hour = secund/3600;
   int forminut = secund % 3600;
 int minut = forminut / 60;
  int forsecund = forminut % 60;
    Console.WriteLine($"{hour}hour,  {minut} minut, {forsecund}secund");
}

Console.ReadKey();