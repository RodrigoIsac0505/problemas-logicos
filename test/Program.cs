using System;

namespace test
{
    class Program
    {
        String[] menu = new String[] {
            "0. Creando una x con un valor dato",
            "1. Verificar cual de 5 numero es el mayor",
            "2. Se generarn 10 numeros y se mostrara cual se repitio más y cuantas veces",
            "3. Ingresar numero y dira si es primo, par o impar",
            "4. Salir"
            };
        public void viewMenu(Program obj)
        {

            for (int i = 0; i < obj.menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }

        }

        public void createdX()
        {
            int opc, temp;

            Console.WriteLine("Elija la base para posteriormente dibujar la X");

            opc = Int32.Parse(Console.ReadLine());
            temp = opc - 1;

            if (opc > 0)
            {
                for (int i = 0; i < opc; i++)
                {
                    for (int i2 = 0; i2 < opc; i2++)
                    {
                        if (i == i2)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            if (temp == i2)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("_");
                            }
                        }
                    }
                    Console.WriteLine("");
                    temp--;
                }
            }
            else
            {
                Console.WriteLine($"Utilize otro dato que sea mayor a {opc}");
            }
        }

        public void numberHigher()
        {
            int higher = 0;
            string temp = "";
            int[] number = new int[5];

            Console.WriteLine("Escrita los 5 numeros para mostrarle cual es el mayor");

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Numero {i + 1} = ");
                number[i] = Int32.Parse(Console.ReadLine());
                temp = temp + number[i].ToString() + " - ";
            }

            Console.WriteLine($"los numeros que introdujo son los siguientes: {temp}");

            for (int i = 0; i < number.Length; i++)
            {
                if (higher < number[i])
                {
                    higher = number[i];
                }
            }
            Console.WriteLine($"El numero mas alto, de la serie de numeros que introdujo es: {higher}");
        }

        public void numberQuantityValue() {
            int[] number = new int[10];
            int[] quantityNumber = new int[5];
            string temp = "";
            int higher = 0;
            int value= 0;

            Random myObject = new Random();

            for (int i = 0; i < number.Length; i++){
                number[i]= myObject.Next(1, 5);
                temp = temp + number[i].ToString() + " - ";
            }

            Console.WriteLine($"los numeros que generados son los siguientes: {temp}");

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 1)
                {
                    quantityNumber[0] = quantityNumber[0]+ 1;
                }
                if (number[i] == 2)
                {
                    quantityNumber[1] = quantityNumber[1]+ 1;
                }
                if (number[i] == 3)
                {
                    quantityNumber[2] = quantityNumber[2]+ 1;
                }
                if (number[i] == 4)
                {
                    quantityNumber[3] = quantityNumber[3]+ 1;
                }
                if (number[i] == 5)
                {
                    quantityNumber[4] = quantityNumber[4] + 1;
                }
            }

            for (int i = 0; i < quantityNumber.Length; i++)
            {
                if (higher < quantityNumber[i])
                {
                    higher = quantityNumber[i];
                    value = i;
                }
            }
            value = value +1;
            Console.WriteLine($"El numero mas repetido fue el {value} y la cantidad que se repitio fue {higher}");

        }

        public void numberPrime(){

            int number,res,div,temp;
            number = 1;

            while (number!=0)
            {
            Console.WriteLine("Escriba el numero 0 para salir ");
            Console.WriteLine("Escriba un numero del 1 al 100, para ver si es primo o no; ademas si es impar o par");

            number = Int32.Parse(Console.ReadLine());

                if (number!=0)
                {
                    res = number % 2;
                    if (number==9)
                    {
                        Console.WriteLine($"El numero: {number} es Impar y No es Primo");
                    }
                    else
                    {
                        if (res>0){
                            int n =3;
                            while (n<=9)
                            {
                                div = number % n;
                                if (div==0 && number != n)
                                {
                                    Console.WriteLine($"El numero: {number} es Impar y No es Primo");
                                    break;     
                                }
                                else
                                {
                                    Console.WriteLine($"El numero: {number} es Impar y Primo");
                                    break;
                                }
                                n = n + 2;
                            }
                        }
                        else{
                            Console.WriteLine($"El numero: {number} es Par y no es Primo");
                        }
                    }
                }else{ 
                    break; 
                }
                Console.ReadKey();
                Console.Clear();
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
                        obj.numberQuantityValue();
                        break;

                    case 3:
                        obj.numberPrime();
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
