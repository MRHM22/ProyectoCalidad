using System;

namespace Calculadora.Negocio
{
    public class Metodo
    {
        public int Sumar(int PrimerValor, int SegundoValor)
        {
            return  PrimerValor + SegundoValor;
        }
        public int Reste(int PrimerValor, int SegundoValor)
        {
            return PrimerValor - SegundoValor;
        }
        public int Multiplique(int PrimerValor, int SegundoValor)
        {
            return PrimerValor * SegundoValor;
        }
        public int Divida(int PrimerValor, int SegundoValor)
        {
            if(PrimerValor==0 || SegundoValor == 0)
            {
                return 0;
            }
            return PrimerValor / SegundoValor;
        }
    }
}
