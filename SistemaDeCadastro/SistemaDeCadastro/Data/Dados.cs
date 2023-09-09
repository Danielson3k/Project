using MySql.Data.MySqlClient;
using SistemaDeCadastro.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro.Data
{
    class Dados : ConexaoDb
    {
        MySqlConnection conexao;
        MySqlCommand comando;
       

        public Dados()
        {
           string srtSql = @"INSERT INTO CLIENTE (NOME,ENDERECO,CEP,BAIRRO,CIDADE,
                             UF,TELEFONE) 
                             VALUES 
                             (@Nome,
                             @Endereco, 
                             @Cep, 
                             @Bairro,
                             @Cidade, 
                             @Uf, 
                             @Telefone);";
            this.conexao = new MySqlConnection(srtConexao);
            this.comando = new MySqlCommand(srtSql, conexao);
            this.comando.Parameters.AddWithValue("@Nome", this.txtNome.Text);
            this.comando.Parameters.AddWithValue("@Endereco", this.txtEndereco.Text);
            this.comando.Parameters.AddWithValue("@Cep", this.mskCep.Text);
            this.comando.Parameters.AddWithValue("@Bairro", this.txtBairro.Text);
            this.comando.Parameters.AddWithValue("@Cidade", this.txtCidade.Text);
            this.comando.Parameters.AddWithValue("@Uf", this.txtUf.Text);
            this.comando.Parameters.AddWithValue("@Telefone", this.mskTelefone.Text);
            this.comando.CommandType = CommandType.Text;
            this.conexao.Open();
            try
            {

                MessageBox.Show("Cadastro criado com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro");
            }
            finally { this.conexao.Close(); }


        }
    }
}
