
List<int> primes = new List<int>();

int number = 2;
while (primes.Count < 10_001)
{
    CheckPrime();
    number++;
}

void CheckPrime()
{
    if(number == 2)
        primes.Add(number);

    if(number % 2 == 0)
        return;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if(number % i == 0)
            return;
    }
    
    primes.Add(number);
}

primes.ForEach(c => Console.WriteLine(c));