
int biggestNumber = 0;

for (var i = 100; i < 1000; i++)
{
    for (int j = 100; j < 1000; j++)
    {
        var number1 = Convert.ToString(i * j);

        var number2Array = number1.ToCharArray();
    
        Array.Reverse(number2Array);

        var number2 = new string(number2Array);

        if (number1 == number2 && Convert.ToInt32(number1) > biggestNumber)
            biggestNumber = Convert.ToInt32(number1);
    }
}

Console.WriteLine(biggestNumber);