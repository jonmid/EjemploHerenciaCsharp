using System;
namespace EjemploHerenciaCsharp
{
    public class Suma:Operacion
    {
        public Suma()
        {
        }

        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }
}
