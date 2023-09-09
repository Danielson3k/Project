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
       

        public void SalvarCadastro()
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
            conexao = new MySqlConnection(srtConexao);
            comando = new MySqlCommand(srtSql, conexao);
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@Cep", mskCep.Text);
            comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            comando.Parameters.AddWithValue("@Uf", txtUf.Text);
            comando.Parameters.AddWithValue("@Telefone", mskTelefone.Text);
            comando.CommandType = CommandType.Text;
            conexao.Open();


        }
    }
}
