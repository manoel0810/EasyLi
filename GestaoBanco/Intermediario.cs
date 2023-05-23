using System;
using System.Data;

namespace GestaoBanco
{
    public class Intermediario
    {
        public static string Chamada()
        {
            string chamada = "";
            try
            {
                var da = Banco.TesteConexao();
                if (da.State == ConnectionState.Open)
                {
                    chamada = "CONECTADO COM ÊXITO";
                    da.Close();
                }
                else
                {
                    chamada = "FALHA NA CONEXÃO";
                }
            }
            catch (Exception)
            {

            }
            return chamada;
        }
        public static DataTable Consultas(string vquery)
        {
            DataTable dt = new DataTable();
            dt = Banco.Consultas(vquery);
            return dt;
        }

        public static bool StatusDB()
        {
            bool resposta;

            var estado = Banco.ConexaoBanco();
            if(estado.State == ConnectionState.Open)
            {
                resposta = true;
                estado.Close();
            }
            else
            {
                resposta = false;
            }

            return resposta;
        }

        public static bool StatusDBX(int BX)
        {
            bool resposta = false;
            
            if (BX == 1)
            {
                var estado = Banco.ConexaoBancoEX(BX);
                if (estado.State == ConnectionState.Open)
                {
                    resposta = true;
                    estado.Close();
                }
                else
                {
                    resposta = false;
                }
            }
            else
            {
                var estado = Banco.ConexaoBancoEX2(BX);
                if (estado.State == ConnectionState.Open)
                {
                    resposta = true;
                    estado.Close();
                }
                else
                {
                    resposta = false;
                }
            }                 
            return resposta;
        }

    }
}
