Console.WriteLine("Por favor introduzca un año");
int anio = int.Parse(Console.ReadLine());

int divisor = 4;

if (anio <= 0)
{
    //False
    Console.WriteLine("El año no puede ser menor a 0");
}

if(anio > 0)
{
    if (anio % divisor == 0 || anio % 100 ==0 || anio % 400 == 0)
    {
        //True
        Console.WriteLine("El año es biciestro");
    }
    else
    {
        //False
        Console.WriteLine("El año no es biciestro");
    }
}       

