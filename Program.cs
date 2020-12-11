using System;
using Polimorfismo.classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe Funcionario
            Funcionario fun = new Funcionario();
            //fun.Mostrar();
            //fun.Mostrar("Tsuka");
            fun.Mostrar(4);
            
            Console.Beep();
        }
    }
}
