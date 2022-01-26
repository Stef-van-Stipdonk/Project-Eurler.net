List<int> multiple = new List<int>();

for (var i = 0; i < 1000; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
        multiple.Add(i);
}

Console.WriteLine(multiple.Sum());