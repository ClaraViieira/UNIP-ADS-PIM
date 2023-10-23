using System;
using PIM_IV.Models;
using PIM_IV.DAO; 

namespace PIM_IV.Controllers
{
    class CtrFuncionarios
    {
        Dao_Funcionarios dao_Funcionarios;

        public CtrFuncionarios()
        {
            dao_Funcionarios = new Dao_Funcionarios();
        }


        public void createFuncionarios(Funcionarios funcionarios)
        {
            dao_Funcionarios.create(funcionarios);
        }

        public void readFuncionarios(Funcionarios funcionarios)
        {
            dao_Funcionarios.read(funcionarios);
        }

        public void deleteFuncionarios(Funcionarios funcionarios)
        {
            dao_Funcionarios.delete(funcionarios);
        }

        public void updateFuncionarios(Funcionarios funcionarios)
        {
            dao_Funcionarios.update(funcionarios);
        }

        public bool validarFuncionario(Funcionarios funcionarios)
        {
            return dao_Funcionarios.validarFuncionario(funcionarios);
        }
    }
}
