using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;

namespace Gerenciador_Oficina
{
    class COnexao
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost; DataBase=OficinaMecanica; Username=postgres; Password=123;");

        internal void AbreConexao()
        {
            
            try
            {
                conexao.Open();
              
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("Erro ao abrir conexao", "erro : " + e, MessageBoxButton.OK, MessageBoxImage.Error);
            }          
        }

        internal void FechaConexao()
        {

            try
            {
                conexao.Close();

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Erro ao fechar conexao", "erro : " + e, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
