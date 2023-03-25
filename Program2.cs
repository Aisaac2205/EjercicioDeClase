void mayor_menor()
{
    int mayor = 0;
    int numero = 0;
    int menor = 10;
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("El número mayor es: |" + mayor+ "|");
    Console.WriteLine("El número menor es: |" + menor+ "|");
}
mayor_menor();  