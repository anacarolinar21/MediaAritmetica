double n1,n2,n3, media;

Console.WriteLine("digite o primeiro número");
n1 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("digite o segundo número");
n2 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("digite o terceiro número");
n3 = Convert.ToDouble(Console.ReadLine())!;

media = (n1+n2+n3) / 3;

Console.WriteLine($"media aritimetica:{media:N2}");