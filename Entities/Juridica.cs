using System;
using System.Collections.Generic;
using System.Text;

namespace PessoaFisicaOuJuridica.Entities {
    class Juridica : Pessoa {
        public int QuantidadeEmpregados { get; set; }

        public Juridica(String nome, double rendaAnual, int quantidadeEmpregados) : base(nome, rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
            QuantidadeEmpregados = quantidadeEmpregados;
        }
        public override double CalculoImposto() {
            if(QuantidadeEmpregados >= 10) {
                return RendaAnual * 0.14;
            } else {
                return RendaAnual * 0.16;
            }
        }
    }
}


