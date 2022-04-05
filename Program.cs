double n1, n2, n3, media;

Console.WriteLine("Media Aritmética de 3 numeros\n");

Console.Write("Digite o primeiro numero..:");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo numero...: ");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro numero..: ");
n3 = Convert.ToDouble(Console.ReadLine()!);

media = (n1 + n2 + n3) / 3; 

Console.WriteLine($"Média: {media:N1}");
