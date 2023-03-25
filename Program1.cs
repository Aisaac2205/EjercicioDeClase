using System.Net.Http.Headers;
using System.Security.Cryptography;

void adivinar()
{
    const int oportunddades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string Linea;
    //generar números al azar del 1-20
    Random ran = new Random();
    do
    {

        NumeroCPU = Convert.ToInt32(ran.Next(100));
        Console.WriteLine(NumeroCPU);
    } while (!((((NumeroCPU >= 1) & (NumeroCPU <= 20)))));

    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Estoy pensando en un numero. ¿Cúal será?");
        Linea = Console.ReadLine();
        NumeroUsuario = Convert.ToInt32(Linea);
        if ((NumeroUsuario > NumeroCPU))
        {
            Console.WriteLine("Adivinaste");
            BanderaControl = 1;
        }
        else
        {
            Console.WriteLine("Te pasaste XD");
        }
        Intentos++;
    } while (((Intentos <= oportunddades) & (BanderaControl == 0)));
    if (BanderaControl == 0)
    {
        Console.WriteLine("El número era: " + NumeroCPU);
    }
}
adivinar();