sub("Hello");
sub(null);

void sub(string? s)
{
    Console.WriteLine(s ?? "(NULL)");
}
