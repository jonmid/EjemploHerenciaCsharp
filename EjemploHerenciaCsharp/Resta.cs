using System;
namespace EjemploHerenciaCsharp
{
    public class Resta:Operacion
    {
        public Resta()
        {
        }

        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }
}
