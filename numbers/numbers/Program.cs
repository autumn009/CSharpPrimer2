sub("123", 123);
sub("123f", 123f);
sub("123d", 123d);
sub("123m", 123m);
sub("123.0", 123.0);
sub("123u", 123u);
sub("123l", 123l); ;
sub("123ul", 123ul);

Console.WriteLine($"0x123: {0x123}");
Console.WriteLine($"0b1010: {0b1010}");

void sub(string name, object val )=>Console.WriteLine($"{name}: {val.GetType().FullName}");
