// See https://aka.ms/new-console-template for more information

Random Random = new Random();
int PersonaCompra = 0;

//Materiales
double CuboJugo = 6000;
double Azucar = 12000;
double Hielo = 18000;
double Total = 0;
double TotalPropina = 0;


while (Console.ReadKey().Key != ConsoleKey.Escape)
{
     PersonaCompra = Random.Next(0, CantPersonas()+1);

    if(PersonaCompra == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Nadie del grupo va a comprar");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Va a comprar la Persona {0}", PersonaCompra);
        Console.WriteLine("");
        AtenderPersona();
        ImprimirAlmacen();
    }
}

int CantPersonas()
{
    int CantidadPersonas = Random.Next(1, 6);

    Console.WriteLine("Grupo de {0}", CantidadPersonas);
    for (int i = 0; i < CantidadPersonas; i++)
    {
        Console.WriteLine("Entrando Persona {0}", i + 1);
    }

    return CantidadPersonas;
}

void AtenderPersona()
{
    int Opcion = Random.Next(1, 4);

    if (CuboJugo != 0 && Azucar != 0 && Hielo != 0)
    {
        if(Opcion == 1)
        {
            CuboJugo = CuboJugo - 2;
            Azucar = Azucar - 2;
            Hielo = Hielo - 3;
            Total = Total + 25;

            Console.WriteLine("Se despacho un Frio Frio Chiquito a la Persona {0} \n\n", PersonaCompra);
        }

        if (Opcion == 2)
        {
            CuboJugo = CuboJugo - (2 * 2.1);
            Azucar = Azucar - 2;
            Hielo = Hielo - 3;
            Total = Total + 50;

            Console.WriteLine("Se despacho un Frio Frio Mediano a la Persona {0} \n\n", PersonaCompra);
        }

        if (Opcion == 3)
        {
            CuboJugo = CuboJugo - (2 * 3.15);
            Azucar = Azucar - 2;
            Hielo = Hielo - 3;
            Total = Total + 90;

            int Propina = Random.Next(1, 3);

            if (Propina == 1)
            {
                Console.WriteLine("Se despacho un Frio Frio Grande a la Persona {0} , Dejando una Propina de 10 Pesos \n\n", PersonaCompra);
                TotalPropina = Total + 10;
            }
            else
            {
                Console.WriteLine("Se despacho un Frio Frio Grande a la Persona {0} \n\n", PersonaCompra);
            }
           
        }
    }


}


void ImprimirAlmacen()
{
    Console.WriteLine("Queda {0} ML de Jugos", CuboJugo);
    Console.WriteLine("Queda {0} ONZ de Azucar", Azucar);
    Console.WriteLine("Queda {0} CUBOS de Hielo\n\n", Hielo);
    Console.WriteLine("Total en Ventas: {0}", Total);
    Console.WriteLine("Total en Porpinas: {0}", TotalPropina);
    

}

