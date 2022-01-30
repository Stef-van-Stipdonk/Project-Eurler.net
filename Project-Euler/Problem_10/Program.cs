using System.Numerics;

List<Int64> primes = new List<Int64>();

int number = 2;

while (true)
{
    CheckPrime();
    number++;

    if (primes.Last() > 2_000_000)
    {
        primes.Remove(primes.Last());
        break;
    }
}

Console.WriteLine(primes.Sum());

void CheckPrime()
{
    if(number == 2)
        primes.Add(number);

    if (number % 2 == 0)
        return;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if(number % i == 0)
            return;
    }

    primes.Add(number);
}