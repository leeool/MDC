int dividendo, resto, divisor;

Console.WriteLine("Máximo Divisor Comum\n");

Console.Write("Digite o 1° número: ");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2° número: ");
divisor = Convert.ToInt32(Console.ReadLine());

do{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
}
while (resto != 0);

Console.WriteLine($"MDC(dividendo, divisor) = {dividendo}");