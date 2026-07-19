var n = 0; 
var nSum = 0;
var nProduct = 1;
Console.WriteLine("Запишите все двузначные числа, \r\nкратные 3 и оканчивающиеся на 4.");
for (int i = 10; i <= 99; i++)
{
    bool bIsTrue = (i % 10 == 4 && i % 3 == 0);
    if(bIsTrue)
    {
        Console.WriteLine("Number N {0} - {1}",(n+1), i);
        nSum += i;
        nProduct *= i;
        n++;
    }
    
}
Console.WriteLine("Сумма указанных чисел равна:{0}", nSum);
Console.WriteLine("Произведение указанных чисел равно:{0}", nProduct);
Console.Read();