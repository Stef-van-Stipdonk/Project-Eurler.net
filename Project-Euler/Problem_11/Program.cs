
using Problem_8;

var numbers = new GenerateNumbers().GetNumberArray();

ulong greatestProduct = 0;

for (var i = 0; i < numbers.Count; i++)
{
    for (int j = 0; j < numbers[i].Count; j++)
    {
        ulong product = 0;
        
        if (numbers.Count - 1 > i + 3 && numbers[i].Count - 1 > j + 3)
        {
            var p1 = (ulong)numbers[i][j];
            var p2 = (ulong)numbers[i + 1][j + 1];
            var p3 = (ulong)numbers[i + 2][j + 2];
            var p4 = (ulong)numbers[i + 3][j + 3];
            
            product = p1 * p2 * p3 * p4;
        }

        if (j - 2 > 0 && numbers.Count - 1 > i + 3)
        {
            var p1 = (ulong)numbers[i][j];
            var p2 = (ulong)numbers[i + 1][j - 1];
            var p3 = (ulong)numbers[i + 2][j - 2];
            var p4 = (ulong)numbers[i + 3][j - 3];

            if (product < p1 * p2 * p3 * p4)
                product = p1 * p2 * p3 * p4;
        }

        if (greatestProduct < product)
            greatestProduct = product;
    }
}

Console.WriteLine(greatestProduct);