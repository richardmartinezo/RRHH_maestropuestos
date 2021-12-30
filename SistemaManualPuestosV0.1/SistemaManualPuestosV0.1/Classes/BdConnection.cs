using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaManualPuestosV0._1.Classes
{
    public class BdConnection
    {
        private SqlCommand sqlcommand;
        private SqlDataReader sqldatareader;
        private string usuarios = "select * from usuarios where usuario = @usuario";
        private string usuariopass = "select * from usuaros where usuario = @usuario and password = @password";
        private string strCon = "Data Source=win-sqlserv-01;Initial Catalog=RRHH;User ID=adminsql;Password=sistema*-!;";


        public string usuarioExiste(string usIngresado) {
            string resultado="";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            sqlcommand = new SqlCommand(usuarios,con);
            if (String.IsNullOrEmpty(usIngresado))
            {
                sqlcommand.Parameters.AddWithValue("@usuario", "");
            }
            else 
            {
                sqlcommand.Parameters.AddWithValue("@usuario", usIngresado);
            }

           
            sqldatareader = sqlcommand.ExecuteReader();
            while(sqldatareader.Read()){
              resultado =  sqldatareader.GetValue(1).ToString();
            }
            
            con.Close();
            return resultado;

        }

        public String[] consultaUsuarioPassword(string usIngresado, string passIngresado)
        {
           // String resultado[2];
            string usuario = "";
            string password = "";
            string nivelaccesoacciones = "";
            string nivellaccesomaestro = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            con.Open();
            sqlcommand = new SqlCommand(usuarios, con);
            if (String.IsNullOrEmpty(usIngresado))
            {
                sqlcommand.Parameters.AddWithValue("@usuario", "");
            }
            else
            {
                sqlcommand.Parameters.AddWithValue("@usuario", usIngresado);
            }
            if (String.IsNullOrEmpty(passIngresado))
            {
                sqlcommand.Parameters.AddWithValue("@password", "");
            }
            else
            {
                sqlcommand.Parameters.AddWithValue("@password", passIngresado);
            }


            sqldatareader = sqlcommand.ExecuteReader();

            while (sqldatareader.Read())
            {
                usuario = sqldatareader.GetValue(1).ToString();
                password = sqldatareader.GetValue(2).ToString();
                nivelaccesoacciones = sqldatareader.GetValue(3).ToString();
                nivellaccesomaestro = sqldatareader.GetValue(4).ToString();
            }

            con.Close();
            return (new String[]{usuario,password,nivelaccesoacciones,nivellaccesomaestro});

        }

    }
}