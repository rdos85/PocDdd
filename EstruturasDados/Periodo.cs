using System;

namespace EstruturasDados
{
    public class Periodo
    {
        public Periodo(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }

        public bool EstaDentroPeriodo(DateTime data)
        {
            if ((data < Inicio) || (data > Fim))
                return false;

            return true;
        }
    }
}
