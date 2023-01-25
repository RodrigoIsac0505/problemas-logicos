using System;

namespace test
{
    class Program
    {
        String[] menu = new String[] {
            "0. Creando una x con un valor dato",
            "1. Verificar cual de 5 numero es el mayor",
            "2. Opcion",
            "3. Opcion",
            "4. Opcion"
            };
        public void viewMenu(Program obj)
        {

            for (int i = 0; i < obj.menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }

        }

        public void numberHigher()
        {
            int higher = 0;
            string temp="";
            int [] number = new int [5];

            Console.WriteLine("Escrita los 5 numeros para mostrarle cual es el mayor");

            for (int i = 0; i < number.Length; i++){
                Console.Write($"Numero {i+1} = ");
                number[i] = Int32.Parse(Console.ReadLine());
                temp = temp + number[i].ToString()+ " - ";
            }

            Console.WriteLine($"los numeros que introdujo son los siguientes: {temp}");

            for (int i = 0; i < number.Length; i++)
            {
                if (higher<number[i]){
                    higher = number[i];
                }
            }
            Console.WriteLine($"El numero mas alto, de la serie de numeros que introdujo es: {higher}");
        }

        public void createdX()
        {
            int opc, temp;

            Console.WriteLine("Elija la base para posteriormente dibujar la X");

            opc = Int32.Parse(Console.ReadLine());
            temp =opc-1;

            if(opc > 0){
                for (int i = 0; i < opc; i++) { 
                    for (int i2 = 0; i2 < opc; i2++){
                        if (i == i2){
                            Console.Write("X");
                        }
                            else{
                                if (temp == i2){
                                    Console.Write("X");
                                }
                                    else{ 
                                        Console.Write("_");
                                    }
                            }
                    }
                 Console.WriteLine("");
                 temp--;
                }
            }
            else { 
                Console.WriteLine($"Utilize otro dato que sea mayor a {opc}");
            }
        }

        static void Main(string[] args)
        {
            int opcion=0;

            Program obj = new Program();

            while (opcion!=4)
            {
                Console.WriteLine("Menu de Opciones!");

                obj.viewMenu(obj);

                opcion = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 0:
                        obj.createdX();
                        break;

                    case 1:
                        obj.numberHigher();
                        break;

                    case 2:
                        Console.WriteLine("opcion ");
                        break;

                    case 3:
                        Console.WriteLine("opcion ");
                        break;

                    case 4:
                        Console.WriteLine("Adios");
                        opcion = 4;
                        break;

                    default:
                        Console.WriteLine("No eligio una opcion valida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
