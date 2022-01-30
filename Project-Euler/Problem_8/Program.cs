using Problem_8;

var numberArray = new GenerateNumbers().GetNumberArray();

ulong largestOutcome = 0;

for (var i = 0; i < numberArray.Count; i++)
{
    if (numberArray.Count == i + 12)
        break;
    
    var range = numberArray.GetRange(i, 13);

    ulong product = 1;
    
    foreach (var number in range)
    {
        product *= (ulong)number;
    }

    if (largestOutcome < product)
        largestOutcome = product;
}

Console.WriteLine(largestOutcome);