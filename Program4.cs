void ejemploarregalo()
{
    //int[] numero = new int[5];
    //int num = 0;
    //int suma = 0;
    //numero[0] = 45;
    //numero[1] = 50;
    //numero[2] = 48;
    //numero[3] = 70;
    //numero[4] = 86;
    //numero[5] = 92;
    //numero[6] = 69;
    int elementos = 3;

    String[] nombres = new String[elementos];
    nombres[0] = "María";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "José";
    nombres[4] = "Rúben";
    nombres[5] = "Ernesto";
    nombres[6] = "Manuel";
    nombres[7] = "Adán";
    nombres[8] = "Isaac";
    nombres[9] = "Josúe";

    Random random = new Random();
    for (int i = 0; i < elementos; i++)
    {
        elementos = random.Next(10);
        Console.WriteLine(elementos);
    }
    Console.WriteLine("El ganador del la pierna de cerdo es: " + random);
    //for (int i = 0; i < 5; i++)
   // {
     //   suma = suma + numero[i];
       // Console.WriteLine(numero[i]);
    //}
    //Console.WriteLine("Sumatoria: " + suma);
    //Console.WriteLine("El promedio es: " + suma / elementos);
}
ejemploarregalo();