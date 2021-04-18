using System;

namespace Calculadora.Negocio
{
    public class Metodo
    {
        public float Sumar(float PrimerValor, float SegundoValor)
        {
            return  PrimerValor + SegundoValor;
        }
        public float Reste(float PrimerValor, float SegundoValor)
        {
            return PrimerValor - SegundoValor;l
        }
        public float Multiplique(float PrimerValor, float SegundoValor)
        {
            return PrimerValor * SegundoValor;
        }
        public float Divida(float PrimerValor, float SegundoValor)
        {
            if(PrimerValor==0 || SegundoValor == 0)
            {
                return 0;
            }
            return PrimerValor / SegundoValor;
        }
    }
}
