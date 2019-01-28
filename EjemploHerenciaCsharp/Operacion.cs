using System;
namespace EjemploHerenciaCsharp
{
    public class Operacion
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;

        public Operacion()
        {
        }

        public int Valor1 { set; get; }
        public int Valor2 { set; get; }
        public int Resultado { set; get; }
    }
}
