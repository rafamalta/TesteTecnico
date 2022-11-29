using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class BancoDeDados
    {

        private const string _strCon = @"server=DESKTOP-B3FJDK0\SQLEXPRESS;" +
                    "user id=sa;" +
                    "password=12345678;" +
                    "database=Teste;" +
                    "persistsecurityinfo=False";
        private string vsql = "";
        public SqlConnection objCon = null;

        public bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }

        }

        public List<Fruta> selectFrutas()
        {
            var frutas = new List<Fruta>();
            vsql = "SELECT DESCRICAO, VALOR_A, VALOR_B FROM FRUTAS ORDER BY DATA_INSERCAO DESC";
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataReader dr;
                    dr = objcmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        var fruta = new Fruta();
                        fruta.Descricao = dr["DESCRICAO"].ToString();
                        fruta.Valor_A = Convert.ToInt32(dr["VALOR_A"].ToString());
                        fruta.Valor_B = Convert.ToInt32(dr["VALOR_B"].ToString());

                        frutas.Add(fruta);
                    }
                }
                catch (Exception ex)

                {
                    throw ex;
                }
            }

            return frutas;
        }
    }
}

