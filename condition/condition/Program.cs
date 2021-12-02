int a = 1;
while (a == 1)
{
    Console.WriteLine($"a={a}");
    a = 2;
}

int b = 1;
while (b < 2)
{
    Console.WriteLine($"b={b}");
    b = b + 1;
}

int c = 1;
while (c <= 2)
{
    Console.WriteLine($"c={c}");
    c = c + 1;
}

float f = float.NaN;
Console.WriteLine($"f==0.0: {f==0.0}");
Console.WriteLine($"f>0.0: {f > 0.0}");
Console.WriteLine($"f<0.0: {f < 0.0}");

string s = "BURN";
Console.WriteLine($"s == \"BURN\": {s == "BURN"}");
Console.WriteLine($"s != \"BURN\": {s != "BURN"}");
