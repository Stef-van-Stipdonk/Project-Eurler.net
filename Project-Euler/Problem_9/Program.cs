
// Solution writeup: 
// Pick two numbers m and n, the larger number should be m and the smaller n
// Calculate a, b and c as follows
// a = m to the power of 2 - n to the power of 2
// b = (m * n)2
// c = m to the power of 2 + n to the power of 2
// a2 + b2 = c2

var productOfTripletToBeFound = 1000;

int a;

for (a = 1; a <= productOfTripletToBeFound / 3; a++)
{
    int b;
    for (b = a + 1; b <= productOfTripletToBeFound / 2; b++)
    {
        int c = productOfTripletToBeFound - a - b;
        if ((a * a) + (b * b) == (c * c))
        {
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"Product: {a * b * c}");
        }
    }
}