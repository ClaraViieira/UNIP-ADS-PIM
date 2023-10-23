using System;
using PIM_IV.Models;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PIM_IV.DAO
{
    class Dao_Funcionarios
    {
        SqlConnection connection = new SqlConnection(@"Data Source=VIEIRMC-W11ASUS\SQLSERVER2022;Initial Catalog=PIM_IV;Integrated Security=True;");

        public void create(Funcionarios funcionarios)
        {
            try
            {
                string commandSql = "INSERT INTO Funcionarios(Nome,CPF,RG,DataNascimento,EstadoCivil,EnderecoCompleto,PIS,TituloEleitor,CTPS,Reservista,Cargo,SalarioBase,IndicadorPlanoSaude,IndicadorPlanoOdonto,IndicadorValeTransporte,IndicadorValeRefeicao,IndicadorValeAlimentacao,Banco,Agencia,Conta) VALUES(@Nome,@CPF,@RG,@DataNascimento,@EstadoCivil,@EnderecoCompleto,@PIS,@TituloEleitor,@CTPS,@Reservista,@Cargo,@SalarioBase,@IndicadorPlanoSaude,@IndicadorPlanoOdonto,@IndicadorValeTransporte,@IndicadorValeRefeicao,@IndicadorValeAlimentacao,@Banco,@Agencia,@Conta)";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@Nome", funcionarios.Nome);
                command.Parameters.AddWithValue("@CPF", funcionarios.CPF);
                command.Parameters.AddWithValue("@RG", funcionarios.RG);
                command.Parameters.AddWithValue("@DataNascimento", funcionarios.DataNascimento);
                command.Parameters.AddWithValue("@EstadoCivil", funcionarios.EstadoCivil);
                command.Parameters.AddWithValue("@EnderecoCompleto", funcionarios.EnderecoCompleto);
                command.Parameters.AddWithValue("@PIS", funcionarios.PIS);
                command.Parameters.AddWithValue("@TituloEleitor", funcionarios.TituloEleitor);
                command.Parameters.AddWithValue("@CTPS", funcionarios.CTPS);
                command.Parameters.AddWithValue("@Reservista", funcionarios.Reservista);
                command.Parameters.AddWithValue("@Cargo", funcionarios.Cargo);
                command.Parameters.AddWithValue("@SalarioBase", funcionarios.SalarioBase);
                command.Parameters.AddWithValue("@IndicadorPlanoSaude", funcionarios.IndicadorPlanoSaude);
                command.Parameters.AddWithValue("@IndicadorPlanoOdonto", funcionarios.IndicadorPlanoOdonto);
                command.Parameters.AddWithValue("@IndicadorValeTransporte", funcionarios.IndicadorValeTransporte);
                command.Parameters.AddWithValue("@IndicadorValeRefeicao", funcionarios.IndicadorValeRefeicao);
                command.Parameters.AddWithValue("@IndicadorValeAlimentacao", funcionarios.IndicadorValeAlimentacao);
                command.Parameters.AddWithValue("@Banco", funcionarios.Banco);
                command.Parameters.AddWithValue("@Agencia", funcionarios.Agencia);
                command.Parameters.AddWithValue("@Conta", funcionarios.Conta);

                command.ExecuteNonQuery();

                MessageBox.Show("Dados incluídos com sucesso!");
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

        public Funcionarios read(Funcionarios funcionarios)
        {
            try
            {
                string commandSql = "SELECT * FROM Funcionarios WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", funcionarios.CPF);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    funcionarios.Nome = Convert.ToString(reader["Nome"]);
                    funcionarios.CPF = Convert.ToString(reader["CPF"]);
                    funcionarios.RG = Convert.ToString(reader["RG"]);
                    funcionarios.EstadoCivil = Convert.ToString(reader["EstadoCivil"]);
                    funcionarios.DataNascimento = Convert.ToString(reader["DataNascimento"]);
                    funcionarios.EnderecoCompleto = Convert.ToString(reader["EnderecoCompleto"]);
                    funcionarios.PIS = Convert.ToString(reader["PIS"]);
                    funcionarios.TituloEleitor = Convert.ToString(reader["TituloEleitor"]);
                    funcionarios.CTPS = Convert.ToString(reader["CTPS"]);
                    funcionarios.Reservista = Convert.ToString(reader["Reservista"]);
                    funcionarios.Cargo = Convert.ToString(reader["Cargo"]);
                    funcionarios.SalarioBase = Convert.ToDecimal(reader["SalarioBase"]);
                    funcionarios.IndicadorPlanoSaude = Convert.ToString(reader["IndicadorPlanoSaude"]);
                    funcionarios.IndicadorPlanoOdonto = Convert.ToString(reader["IndicadorPlanoOdonto"]);
                    funcionarios.IndicadorValeTransporte = Convert.ToString(reader["IndicadorValeTransporte"]);
                    funcionarios.IndicadorValeRefeicao = Convert.ToString(reader["IndicadorValeRefeicao"]);
                    funcionarios.IndicadorValeAlimentacao = Convert.ToString(reader["IndicadorValeAlimentacao"]);
                    funcionarios.Banco = Convert.ToString(reader["Banco"]);
                    funcionarios.Agencia = Convert.ToString(reader["Agencia"]);
                    funcionarios.Conta = Convert.ToString(reader["Conta"]);
                }
                return funcionarios;
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

        public void delete(Funcionarios funcionarios)
        {
            try
            {
                string commandSql = "DELETE FROM Funcionarios WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", funcionarios.CPF);

                command.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso.");
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

        public void update(Funcionarios funcionarios)
        {
            try
            {
                string commandSql = "UPDATE Funcionarios SET Nome = @Nome, RG = @RG, DataNascimento = @DataNascimento, EstadoCivil = @EstadoCivil, @EnderecoCompleto = EnderecoCompleto, @PIS = PIS, @TituloEleitor = TituloEleitor, @CTPS = CTPS, @Reservista = Reservista, @Cargo = Cargo, @SalarioBase = SalarioBase, @IndicadorPlanoSaude = IndicadorPlanoSaude, @IndicadorPlanoOdonto = IndicadorPlanoOdonto, @IndicadorValeTransporte = IndicadorValeTransporte, @IndicadorValeRefeicao = IndicadorValeRefeicao, @IndicadorValeAlimentacao = IndicadorValeAlimentacao, @Banco = Banco, @Agencia = Agencia, @Conta = Conta WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                command.Parameters.AddWithValue("@CPF", funcionarios.CPF);

                connection.Open();

                command.Parameters.AddWithValue("@Nome", funcionarios.Nome);
                command.Parameters.AddWithValue("@RG", funcionarios.RG);
                command.Parameters.AddWithValue("@DataNascimento", funcionarios.DataNascimento);
                command.Parameters.AddWithValue("@EstadoCivil", funcionarios.EstadoCivil);
                command.Parameters.AddWithValue("@EnderecoCompleto", funcionarios.EnderecoCompleto);
                command.Parameters.AddWithValue("@PIS", funcionarios.PIS);
                command.Parameters.AddWithValue("@TituloEleitor", funcionarios.TituloEleitor);
                command.Parameters.AddWithValue("@CTPS", funcionarios.CTPS);
                command.Parameters.AddWithValue("@Reservista", funcionarios.Reservista);
                command.Parameters.AddWithValue("@Cargo", funcionarios.Cargo);
                command.Parameters.AddWithValue("@SalarioBase", funcionarios.SalarioBase);
                command.Parameters.AddWithValue("@IndicadorPlanoSaude", funcionarios.IndicadorPlanoSaude);
                command.Parameters.AddWithValue("@IndicadorPlanoOdonto", funcionarios.IndicadorPlanoOdonto);
                command.Parameters.AddWithValue("@IndicadorValeTransporte", funcionarios.IndicadorValeTransporte);
                command.Parameters.AddWithValue("@IndicadorValeRefeicao", funcionarios.IndicadorValeRefeicao);
                command.Parameters.AddWithValue("@IndicadorValeAlimentacao", funcionarios.IndicadorValeAlimentacao);
                command.Parameters.AddWithValue("@Banco", funcionarios.Banco);
                command.Parameters.AddWithValue("@Agencia", funcionarios.Agencia);
                command.Parameters.AddWithValue("@Conta", funcionarios.Conta);

                command.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso!");
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

        public bool validarFuncionario(Funcionarios funcionarios)
        {
            try
            {
                string commandSql = "SELECT * FROM Funcionarios WHERE CPF = @CPF";
                SqlCommand command = new SqlCommand(commandSql, connection);

                connection.Open();

                command.Parameters.AddWithValue("@CPF", funcionarios.CPF);

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
