List<int> list = new List<int>();

var a = 0;
var b = 1;
var c = 0;
while(c < 4_000_000)
{
    a = b;
    b = c;
    c = a + b;
    
    if(c % 2 == 0)
        list.Add(c);
}

Console.WriteLine(list.Sum());