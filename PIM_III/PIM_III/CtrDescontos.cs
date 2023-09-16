using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    class CtrDescontos
    {
        public decimal CalcularINSS(Descontos descontos)
        {
            if (descontos.SalarioBruto <= 1320)
                return descontos.SalarioBruto * 0.075m;
            else if (descontos.SalarioBruto <= 2571.29m)
                return descontos.SalarioBruto * 0.09m;
            else if (descontos.SalarioBruto <= 3856.94m)
                return descontos.SalarioBruto * 0.12m;
            else
                return descontos.SalarioBruto * 0.14m;
        }

        public decimal CalcularIRRF(Descontos descontos)
        {
            if (descontos.SalarioBruto <= 2112m)
                return 0m;
            else if (descontos.SalarioBruto <= 2826.65m)
                return (descontos.SalarioBruto * 0.075m) - 142.80m;
            else if (descontos.SalarioBruto <= 3751.05m)
                return (descontos.SalarioBruto * 0.15m) - 354.80m;
            else if (descontos.SalarioBruto <= 4664.68m)
                return (descontos.SalarioBruto * 0.225m) - 636.13m;
            else
                return (descontos.SalarioBruto * 0.275m) - 869.36m;
        }

        public decimal CalcularPlanoSaude(Descontos descontos, Funcionarios funcionarios)
        {
            if (descontos.IndicadorPlanoSaude == "S")
                return funcionarios.SalarioBase * 0.03m;
            else
                return 0m;
        }

        public decimal CalcularPlanoOdontologico(Descontos descontos, Funcionarios funcionarios)
        {
            if (descontos.IndicadorPlanoOdonto == "S")
                return funcionarios.SalarioBase * 0.02m;
            else
                return 0m;
        }

        public decimal CalcularValeTransporte(Descontos descontos)
        {
            if (descontos.IndicadorValeTransporte == "S")
            {
                if (descontos.QtdeDiasFaltas == 0)
                {
                    //Passagem Campinas ida e volta: 10,80
                    decimal valeTransporteoPorDia = 10.80m;
                    return (valeTransporteoPorDia * descontos.QtdeDiasTrabalhados) * 0.06m;
                }
                else
                {
                    decimal valeTransporteoPorDia = 10.80m;
                    return (valeTransporteoPorDia * (descontos.QtdeDiasTrabalhados - descontos.QtdeDiasFaltas)) * 0.06m;
                }
            }
            else
                return 0m;
        }

        public decimal CalcularValeAlimentacao(Descontos descontos)
        {
            if (descontos.IndicadorValeAlimentacao == "S")
            {
                decimal valeAlimentacao = 400m;
                return valeAlimentacao * 0.10m;
            }
            else
                return 0m;
        }

        public decimal CalcularValeRefeicao(Descontos descontos)
        {
            if (descontos.IndicadorValeRefeicao == "S")
            {
                if (descontos.QtdeDiasFaltas == 0)
                {
                    decimal valeRefeicaoPorDia = 16m;
                    return (valeRefeicaoPorDia * descontos.QtdeDiasTrabalhados) * 0.10m;
                }
                else
                {
                    decimal valeRefeicaoPorDia = 10.80m;
                    return (valeRefeicaoPorDia * (descontos.QtdeDiasTrabalhados - descontos.QtdeDiasFaltas)) * 0.10m;
                }
            }
            else
                return 0m;
        }
    }
}
