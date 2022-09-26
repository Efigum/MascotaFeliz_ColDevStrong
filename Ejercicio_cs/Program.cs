Console.WriteLine("Seleccione la opcion deseada:\n 1. Escalera ascendente\n 2. Escalera invertida\n 3. Cuadrado");
string? opcion;
opcion=Console.ReadLine();

if (opcion == "1")
{
    Console.WriteLine("Ingrese los pasos de la escalera");
    string? pasos;
    pasos=Console.ReadLine();

    int escalon = Int32.Parse(pasos);

    for (int i=0;i<escalon-1;i++)
    {
        for (int j=0;j<=i;j++)
        {
            Console.Write("-");
        }
        Console.Write("\n");
    }
 
}
    
if (opcion == "2")
{
    Console.WriteLine("Ingrese los pasos de la escalera");
    string? pasos;
    pasos=Console.ReadLine();

    int escalon = Int32.Parse(pasos);

    for (int i=0;i<escalon-1;i++)
    {
        for (int j=0;j<=i;j++)
        {
            Console.Write("-");
        }
        Console.Write("\n");
    }
 
}

if (opcion == "3")
{
    Console.WriteLine("Ingrese los pasos de la escalera");
    string? pasos;
    pasos=Console.ReadLine();

    int escalon = Int32.Parse(pasos);

    for (int i=0;i<escalon-1;i++)
    {
        for (int j=0;j<=i;j++)
        {
            Console.Write("-");
        }
        Console.Write("\n");
    }
 
}

