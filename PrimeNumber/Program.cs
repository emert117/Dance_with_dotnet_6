Console.Write("Enter a Number : ");
int number = int.Parse(Console.ReadLine());
bool IsPrime = true;
int dividedBy = 2;

for (int i = 2; i < number/2; i++)
{
    if (number % i == 0)
    {
        IsPrime = false;
        dividedBy = i;
        break;
    }
}

if (IsPrime)
    Console.WriteLine("Number is Prime.");
else
    Console.WriteLine($"Number is not Prime. It is divided by {dividedBy}");

Console.ReadKey();