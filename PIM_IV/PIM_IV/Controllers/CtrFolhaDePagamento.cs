using System;
using PIM_IV.Models;
using PIM_IV.DAO;

namespace PIM_IV.Controllers
{
    class CtrFolhaDePagamento
    {
        Dao_FolhaPagamento dao_FolhaPagamento;
        CtrProventos ctrProventos;
        CtrDescontos ctrDescontos; 

        public CtrFolhaDePagamento()
        {
            dao_FolhaPagamento = new Dao_FolhaPagamento();
            ctrProventos = new CtrProventos();
            ctrDescontos = new CtrDescontos(); 
        }

        public void readFuncionarios(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            dao_FolhaPagamento.readFuncionarios(descontos,folhaDePagamento);
        }

        public void createFolhaPagamento(Descontos descontos, Proventos proventos, FolhaDePagamento folhaDePagamento)
        {
            ctrProventos.Proventos(proventos, folhaDePagamento);
            ctrDescontos.Descontos(descontos, folhaDePagamento);
            dao_FolhaPagamento.create(folhaDePagamento);
        }

        public void readFolhaPagamento(FolhaDePagamento folhaDePagamento)
        {
            dao_FolhaPagamento.read(folhaDePagamento);
        }

        public bool validarCpfFuncionario(FolhaDePagamento folhaDePagamento)
        {
            return dao_FolhaPagamento.validarCpfFuncionario(folhaDePagamento);
        }

        public bool validarCpfFolhaPagamento(FolhaDePagamento folhaDePagamento)
        {
            return dao_FolhaPagamento.validarCpfFolhaPagamento(folhaDePagamento);
        }
    }
}
