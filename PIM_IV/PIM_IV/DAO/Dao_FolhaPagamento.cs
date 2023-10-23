using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PIM_IV.Models;

namespace PIM_IV.DAO
{
    class Dao_FolhaPagamento
    {
        SqlConnection connection = new SqlConnection(@"Data Source=VIEIRMC-W11ASUS\SQLSERVER2022;Initial Catalog=PIM_IV;Integrated Security=True;");

        public Descontos readFuncionarios(Descontos descontos, FolhaDePagamento folhaDePagamento)
        {
            try
            {
                string commandSql = "SELECT * FROM Funcionarios WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", folhaDePagamento.CPF);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    folhaDePagamento.Nome = Convert.ToString(reader["Nome"]);
                    folhaDePagamento.SalarioBase = Convert.ToDecimal(reader["SalarioBase"]);
                    descontos.IndicadorPlanoSaude = Convert.ToString(reader["IndicadorPlanoSaude"]);
                    descontos.IndicadorPlanoOdonto = Convert.ToString(reader["IndicadorPlanoOdonto"]);
                    descontos.IndicadorValeTransporte = Convert.ToString(reader["IndicadorValeTransporte"]);
                    descontos.IndicadorValeRefeicao = Convert.ToString(reader["IndicadorValeRefeicao"]);
                    descontos.IndicadorValeAlimentacao = Convert.ToString(reader["IndicadorValeAlimentacao"]);
                }
                return descontos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public void create(FolhaDePagamento folhaDePagamento)
        {
            try
            {
                string commandSql = "INSERT INTO FolhaDePagamento(Nome,CPF,MesReferencia,ProventoAdicionalNoturno,ProventoHorasExtras,ProventoComissao,DescontoINSS,DescontoIRRF,DescontoVT,DescontoVA,DescontoVR,DescontoPS,DescontoPO,SalarioBase,SalarioBruto,SalarioLiquido) VALUES(@Nome,@CPF,@MesReferencia,@ProventoAdicionalNoturno,@ProventoHorasExtras,@ProventoComissao,@DescontoINSS,@DescontoIRRF,@DescontoVT,@DescontoVA,@DescontoVR,@DescontoPS,@DescontoPO,@SalarioBase,@SalarioBruto,@SalarioLiquido)";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@Nome", folhaDePagamento.Nome);
                command.Parameters.AddWithValue("@CPF", folhaDePagamento.CPF);
                command.Parameters.AddWithValue("@MesReferencia", folhaDePagamento.MesReferencia);
                command.Parameters.AddWithValue("@ProventoAdicionalNoturno", folhaDePagamento.ProventoAdicionalNoturno);
                command.Parameters.AddWithValue("@ProventoHorasExtras", folhaDePagamento.ProventoHorasExtras);
                command.Parameters.AddWithValue("@ProventoComissao", folhaDePagamento.ProventoComissao);
                command.Parameters.AddWithValue("@DescontoINSS", folhaDePagamento.DescontoINSS);
                command.Parameters.AddWithValue("@DescontoIRRF", folhaDePagamento.DescontoIRRF);
                command.Parameters.AddWithValue("@DescontoVT", folhaDePagamento.DescontoVT);
                command.Parameters.AddWithValue("@DescontoVA", folhaDePagamento.DescontoVA);
                command.Parameters.AddWithValue("@DescontoVR", folhaDePagamento.DescontoVR);
                command.Parameters.AddWithValue("@DescontoPS", folhaDePagamento.DescontoPS);
                command.Parameters.AddWithValue("@DescontoPO", folhaDePagamento.DescontoPO);
                command.Parameters.AddWithValue("@SalarioBase", folhaDePagamento.SalarioBase);
                command.Parameters.AddWithValue("@SalarioBruto", folhaDePagamento.SalarioBruto);
                command.Parameters.AddWithValue("@SalarioLiquido", folhaDePagamento.SalarioLiquido);

                command.ExecuteNonQuery();

                MessageBox.Show("Registros incluídos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public FolhaDePagamento read(FolhaDePagamento folhaDePagamento)
        {
            try
            {
                string commandSql = "SELECT * FROM FolhaDePagamento WHERE CPF = @CPF AND MesReferencia = @MesReferencia";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", folhaDePagamento.CPF);
                command.Parameters.AddWithValue("@MesReferencia", folhaDePagamento.MesReferencia);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    folhaDePagamento.Nome = Convert.ToString(reader["Nome"]);
                    folhaDePagamento.CPF = Convert.ToString(reader["CPF"]);
                    folhaDePagamento.MesReferencia = Convert.ToString(reader["MesReferencia"]);
                    folhaDePagamento.ProventoAdicionalNoturno = Convert.ToDecimal(reader["ProventoAdicionalNoturno"]);
                    folhaDePagamento.ProventoHorasExtras = Convert.ToDecimal(reader["ProventoHorasExtras"]);
                    folhaDePagamento.ProventoComissao = Convert.ToDecimal(reader["ProventoComissao"]);
                    folhaDePagamento.DescontoINSS = Convert.ToDecimal(reader["DescontoINSS"]);
                    folhaDePagamento.DescontoIRRF = Convert.ToDecimal(reader["DescontoIRRF"]);
                    folhaDePagamento.DescontoVT = Convert.ToDecimal(reader["DescontoVT"]);
                    folhaDePagamento.DescontoVA = Convert.ToDecimal(reader["DescontoVA"]);
                    folhaDePagamento.DescontoVR = Convert.ToDecimal(reader["DescontoVR"]);
                    folhaDePagamento.DescontoPO = Convert.ToDecimal(reader["DescontoPO"]);
                    folhaDePagamento.DescontoPS = Convert.ToDecimal(reader["DescontoPS"]);
                    folhaDePagamento.SalarioBase = Convert.ToDecimal(reader["SalarioBase"]);
                    folhaDePagamento.SalarioBruto = Convert.ToDecimal(reader["SalarioBruto"]);
                    folhaDePagamento.SalarioLiquido = Convert.ToDecimal(reader["SalarioLiquido"]);
                }
                return folhaDePagamento;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool validarCpfFuncionario(FolhaDePagamento folhaDePagamento)
        {
            try
            {
                string commandSql = "SELECT * FROM Funcionarios WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", folhaDePagamento.CPF);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool validarCpfFolhaPagamento(FolhaDePagamento folhaDePagamento)
        {
            try
            {
                string commandSql = "SELECT * FROM FolhaDePagamento WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", folhaDePagamento.CPF);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
