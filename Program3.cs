void catcher ()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese una cantidad: ");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        cantidad = cantidad / 0;
    }catch (FormatException fex) 
    {
        Console.WriteLine("Ingreso mal el número" + fex.Message);
    }catch (Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo: "+ ex.Message);
    }
    if (cantidad > 0)
    {
        Console.WriteLine("Cantidad ingresada: " + cantidad);
    }

}
catcher();
