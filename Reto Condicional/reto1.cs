using System;


CheckNumber();

void CheckNumber()
{
    int numero = 0;

    if (numero > 0)
    {
        Console.WriteLine("El numero es positivo");
    }
    else if (numero == 0)
    {
        Console.WriteLine("El numero es 0");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El numero es negativo");
    }
    else
    {
        Console.WriteLine("valor invalido");
    }
}