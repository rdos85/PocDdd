using EstruturasDados;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsistenciaProposta.Entities
{
    public class Consistencia
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Niveis Nivel { get; set; }
        public Periodo Vigencia { get; set; }

        public enum Niveis
        {
            Normal,
            Critica
        }
    }
}
