using System;
namespace Fibonacci.Logic
{
	public class FibonacciLogic: IFibonaccinterface
    {
		 

        public int GetFibonacci(int value)
        {
            int valorInicial1 = 0;
            int valorinicial2 = 1;

            //Mostramos el primer número el 0.


            //En este caso generamos 30 sucesiones del código Fibonacci.
            for (int i = 0; i < value; i++)
            {
                //Almacenamos el valor v1 en una variable temporal para no perderlo.
                int temp = valorInicial1;

                //El valor 1 se convierte en el valor 2.
                valorInicial1 = valorinicial2;

                //Sumamos los valores.
                valorinicial2 = temp + valorInicial1;

                //Mostramos por pantalla el resultado. 
                Console.WriteLine(valorInicial1);
            }

            return valorInicial1;

        }
    }
}

