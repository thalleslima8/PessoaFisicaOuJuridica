using System;
using System.Collections.Generic;
using System.Text;

namespace PessoaFisicaOuJuridica.Entities {
    class Fisica : Pessoa {

        public double DespesasSaude { get; set; }

        public Fisica(String nome, double rendaAnual, double despesasSaude) : base(nome, rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
            DespesasSaude = despesasSaude;
        }

        public override double CalculoImposto() {
            if (RendaAnual <= 20000) {
                return (RendaAnual * 0.15) - (DespesasSaude * 0.5);
            } else {
                return (RendaAnual * 0.25) - (DespesasSaude * 0.5);
            }
            
        }
    }
}
