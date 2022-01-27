

int number = 1;
var numberFound = false;
while (!numberFound)
{
    for (var i = 1; i < 21; i++)
    {
        if (number % i != 0)
        {
            number++;
            break;
        }

        if (i == 20)
        {
            Console.WriteLine(number);
            numberFound = true;
        }
    }
}