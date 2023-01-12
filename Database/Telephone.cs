using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PesquisaEstados.Database
{
    class Telephone
    {
        private string sigla { get; set; }
        private string cidade { get; set; }
        private string estado { get; set; }
        private string ddd { get; set; }

        public static DataTable StartList(bool active)
        {
            var dt = new DataTable();
            var querry = "select estado.uf as \"Sigla\", estado.nome as \"Estado\" , cidade.nome as Cidade, estado.ddd as \"ddd\" from cidade INNER \r\nJOIN estado on cidade.uf=estado.id";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(querry, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static DataTable GetList(string cidade, string estado,string sigla, string ddd)
        {
            var dt = new DataTable();
            var querry = $"select estado.uf as \"Sigla\", estado.nome as \"Estado\" , cidade.nome as Cidade, estado.ddd as \"ddd\" from cidade INNER JOIN estado on " +
                $"cidade.uf=estado.id and " +
                $"cidade.nome like '%{cidade}%'and " +
                $"estado.nome like '%{estado}%'and estado.uf like'%{sigla}%'" +
                $"and estado.ddd like '%{ddd}%'";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(querry, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
