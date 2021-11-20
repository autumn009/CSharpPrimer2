sub<float>("float", float.MaxValue, float.MinValue);
sub<double>("double", double.MaxValue, double.MinValue);
sub<decimal>("decimal", decimal.MaxValue, decimal.MinValue);

static void sub<T>(string name, T max, T min) => Console.WriteLine($"名前:{name,-10} 本名:{typeof(T).FullName,-14} 最大値:{max,32} 最小値:{min,32}");
