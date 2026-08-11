var n = 0;
var nSum = 0;
var nProduct = 1;
Console.WriteLine("Write down all two-digit numbers that are multiples of 3 and end in 4.");
for (int i = 10; i <= 99; i++)
{
    bool bIsTrue = (i % 10 == 4 && i % 3 == 0);
    if (bIsTrue)
    {
        Console.WriteLine("Number N {0} - {1}", (n + 1), i);
        nSum += i;
        nProduct *= i;
        n++;
    }

}
Console.WriteLine("The sum of the given numbers is equal to:{0}", nSum);
Console.WriteLine("The product of the given numbers is equal to:{0}", nProduct);
Console.Read();
