
int sumOfSquares = 0;
int squareOfSum = 0;

for (var i = 0; i < 101; i++)
{
       sumOfSquares += i * i;
       squareOfSum += i;
}

squareOfSum = squareOfSum * squareOfSum;

Console.WriteLine($"{squareOfSum} + {sumOfSquares} = {squareOfSum - sumOfSquares}");