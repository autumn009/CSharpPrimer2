var d = new DateTime(2030, 1, 2, 12, 0, 0); // 2030年1月2日12時0分0秒
d = d.AddMinutes(30);   // 30分加算
Console.WriteLine(d);
Console.WriteLine(d.ToLongDateString());
Console.WriteLine(d.ToLongTimeString());
Console.WriteLine(d.ToShortDateString());
Console.WriteLine(d.ToShortTimeString());
