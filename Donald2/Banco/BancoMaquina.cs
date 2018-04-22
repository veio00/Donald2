﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Donald2.Banco
{
    public class BancoMaquina
    {
        private Conexao ObjBanco;

        public BancoMaquina()
        {
            ObjBanco = new Conexao();
        }
        ~BancoMaquina()
        {
            ObjBanco = null;
        }

        public DataTable Carregar_Maquina(int empresa)
        {
            try
            {

                List<SqlParameter> LstParametros = new List<SqlParameter>();

                DataTable dt = ObjBanco.ExecuteQuery("select * from Maquina where Grupo_Cliente =" + empresa +" ", LstParametros);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}