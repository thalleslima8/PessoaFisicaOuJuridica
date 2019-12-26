using System;
using System.Collections.Generic;
using System.Text;

namespace PessoaFisicaOuJuridica.Entities {
    abstract class Pessoa {

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();
    }
}
