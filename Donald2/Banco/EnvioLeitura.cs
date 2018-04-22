using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Donald2.Banco
{
    public class EnvioLeitura
    {
        private Conexao ObjBanco;

        public EnvioLeitura()
        {
            ObjBanco = new Conexao();
        }
        ~EnvioLeitura()
        {
            ObjBanco = null;
        }

        public DataTable Carregar_Leitura()
        {
            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery("select * from leitura where Maquina_Uso= 1 ", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}