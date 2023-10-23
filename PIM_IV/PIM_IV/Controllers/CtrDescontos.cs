using System;
using PIM_IV.Models;

namespace PIM_IV.Controllers
{
    class CtrDescontos
    {
        public decimal CalcularINSS(FolhaDePagamento folhaDePagamento)
        {
            if (folhaDePagamento.SalarioBruto <= 1320)
            {
                folhaDePagamento.DescontoINSS = folhaDePagamento.SalarioBruto * 0.075m;
                folhaDePagamento.DescontoINSS = Math.Round(folhaDePagamento.DescontoINSS, 2);
                return folhaDePagamento.DescontoINSS;
            }
            else if (folhaDePagamento.SalarioBruto <= 2571.29m)
            {
                folhaDePagamento.DescontoINSS = folhaDePagamento.SalarioBruto * 0.09m;
                folhaDePagamento.DescontoINSS = Math.Round(folhaDePagamento.DescontoINSS, 2);
                return folhaDePagamento.DescontoINSS;
            }
            else if (folhaDePagamento.SalarioBruto <= 3856.94m)
            {
                folhaDePagamento.DescontoINSS = folhaDePagamento.SalarioBruto * 0.12m;
                folhaDePagamento.DescontoINSS = Math.Round(folhaDePagamento.DescontoINSS, 2);
                return folhaDePagamento.DescontoINSS;
            }
            else
            {
                folhaDePagamento.DescontoINSS = folhaDePagamento.SalarioBruto * 0.14m;
                folhaDePagamento.DescontoINSS = Math.Round(folhaDePagamento.DescontoINSS, 2);
                return folhaDePagamento.DescontoINSS;
            }
        }

        public decimal CalcularIRRF(FolhaDePagamento folhaDePagamento)
        {
            if (folhaDePagamento.SalarioBruto <= 2112)
                return folhaDePagamento.DescontoIRRF = 0;
            else if (folhaDePagamento.SalarioBruto <= 2826.65m)
            {
                folhaDePagamento.DescontoIRRF = (folhaDePagamento.SalarioBruto * 0.075m) - 142.80m;
                folhaDePagamento.DescontoIRRF = Math.Round(folhaDePagamento.DescontoIRRF, 2);
                return folhaDePagamento.DescontoIRRF;
            }
            else if (folhaDePagamento.SalarioBruto <= 3751.05m)
            {
                folhaDePagamento.DescontoIRRF = (folhaDePagamento.SalarioBruto * 0.15m) - 354.80m;
                folhaDePagamento.DescontoIRRF = Math.Round(folhaDePagamento.DescontoIRRF, 2);
                return folhaDePagamento.DescontoIRRF;
            }
            else if (folhaDePagamento.SalarioBruto <= 4664.68m)
            {
                folhaDePagamento.DescontoIRRF = (folhaDePagamento.SalarioBruto * 0.225m) - 636.13m;
                folhaDePagamento.DescontoIRRF = Math.Round(folhaDePagamento.DescontoIRRF, 2);
                return folhaDePagamento.DescontoIRRF;
            }
            else
            {
                folhaDePagamento.DescontoIRRF = (folhaDePagamento.SalarioBruto * 0.275m) - 869.36m;
                folhaDePagamento.DescontoIRRF = Math.Round(folhaDePagamento.DescontoIRRF, 2);
                return folhaDePagamento.DescontoIRRF;
            }
        }

        public decimal CalcularPlanoSaude(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            if (descontos.IndicadorPlanoSaude == "Sim")
            {
                folhaDePagamento.DescontoPS = folhaDePagamento.SalarioBase * 0.03m;
                folhaDePagamento.DescontoPS = Math.Round(folhaDePagamento.DescontoPS, 2);
                return folhaDePagamento.DescontoPS;
            }
            else
                return folhaDePagamento.DescontoPS = 0;
        }

        public decimal CalcularPlanoOdontologico(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            if (descontos.IndicadorPlanoOdonto == "Sim")
            {
                folhaDePagamento.DescontoPO = folhaDePagamento.SalarioBase * 0.02m;
                folhaDePagamento.DescontoPO = Math.Round(folhaDePagamento.DescontoPO, 2);
                return folhaDePagamento.DescontoPO;
            }
            else
                return folhaDePagamento.DescontoPO = 0;
        }

        public decimal CalcularValeTransporte(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            if (descontos.IndicadorValeTransporte == "Sim")
            {
                if (descontos.QtdeDiasFaltas == 0)
                {
                    //Passagem Campinas ida e volta: 10,80
                    decimal valeTransporteoPorDia = 10.80m;
                    folhaDePagamento.DescontoVT = (valeTransporteoPorDia * descontos.QtdeDiasTrabalhados) * 0.06m;
                    folhaDePagamento.DescontoVT = Math.Round(folhaDePagamento.DescontoVT, 2);
                    return folhaDePagamento.DescontoVT;
                }
                else
                {
                    decimal valeTransporteoPorDia = 10.80m;
                    folhaDePagamento.DescontoVT = (valeTransporteoPorDia * (descontos.QtdeDiasTrabalhados - descontos.QtdeDiasFaltas)) * 0.06m;
                    folhaDePagamento.DescontoVT = Math.Round(folhaDePagamento.DescontoVT, 2);
                    return folhaDePagamento.DescontoVT;
                }
            }
            else
                return folhaDePagamento.DescontoVT = 0;
        }

        public decimal CalcularValeAlimentacao(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            if (descontos.IndicadorValeAlimentacao == "Sim")
            {
                decimal valeAlimentacao = 400;
                folhaDePagamento.DescontoVA = valeAlimentacao * 0.10m;
                folhaDePagamento.DescontoVA = Math.Round(folhaDePagamento.DescontoVA, 2);
                return folhaDePagamento.DescontoVA;
            }
            else
                return folhaDePagamento.DescontoVA = 0;
        }

        public decimal CalcularValeRefeicao(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            if (descontos.IndicadorValeRefeicao == "Sim")
            {
                if (descontos.QtdeDiasFaltas == 0)
                {
                    decimal valeRefeicaoPorDia = 16;
                    folhaDePagamento.DescontoVR = (valeRefeicaoPorDia * descontos.QtdeDiasTrabalhados) * 0.10m;
                    folhaDePagamento.DescontoVR = Math.Round(folhaDePagamento.DescontoVR, 2);
                    return folhaDePagamento.DescontoVR;
                }
                else
                {
                    decimal valeRefeicaoPorDia = 10.80m;
                    folhaDePagamento.DescontoVR = (valeRefeicaoPorDia * (descontos.QtdeDiasTrabalhados - descontos.QtdeDiasFaltas)) * 0.10m;
                    folhaDePagamento.DescontoVR = Math.Round(folhaDePagamento.DescontoVR, 2);
                    return folhaDePagamento.DescontoVR;
                }
            }
            else
                return folhaDePagamento.DescontoVR = 0;
        }

        public decimal SalarioLiquido(FolhaDePagamento folhaDePagamento)
        {
            var calculo = folhaDePagamento.DescontoINSS + folhaDePagamento.DescontoIRRF + folhaDePagamento.DescontoPO + folhaDePagamento.DescontoPS
                + folhaDePagamento.DescontoVA + folhaDePagamento.DescontoVR + folhaDePagamento.DescontoVT;
            folhaDePagamento.SalarioLiquido = folhaDePagamento.SalarioBruto - calculo;
            folhaDePagamento.SalarioLiquido = Math.Round(folhaDePagamento.SalarioLiquido, 2);
            return folhaDePagamento.SalarioLiquido;
        }

        public void Descontos(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            CalcularINSS(folhaDePagamento);
            CalcularIRRF(folhaDePagamento);
            CalcularPlanoSaude(descontos, folhaDePagamento);
            CalcularPlanoOdontologico(descontos, folhaDePagamento);
            CalcularValeTransporte(descontos, folhaDePagamento);
            CalcularValeAlimentacao(descontos, folhaDePagamento);
            CalcularValeRefeicao(descontos, folhaDePagamento);
            SalarioLiquido(folhaDePagamento);
        }
    }
}
