
List<int> primes = new List<int>();

var number = 600_851_475_143;

for (int i = 2; i <= number; i++)
{
    while (number % i == 0)
    {
        primes.Add(i);
        number = number / i;
    }
}

primes.ForEach(c => Console.WriteLine(c));