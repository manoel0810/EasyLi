using System;
using System.ServiceProcess;

namespace GestaoBanco
{
    public class Globais
    {
        public static int Conectado = Banco.RetornoCon;
        public static int con = 0;
        public static string username = "";
        public static string caminhoSel = "";
        public static string email = "";

        public static string LB1 = "";
        public static string LB2 = "";

        public static string ConexaoBX(int BX)
        {
            string Con = "";
            if(BX == 1)
            {
                Con = LB1;
            }else if(BX == 2)
            {
                Con = LB2;
            }
            return Con;
        }
        

        public static string FormatarTxt(string conteudo)
        {
            if (conteudo.Contains("\'"))
            {
                conteudo = conteudo.Replace("\'", "");
            }
            return conteudo;
        }

        public static ServiceControllerStatus VerificarServico(string nomeServiço)
        {
            ServiceController[] services = ServiceController.GetServices();
            ServiceControllerStatus stado = ServiceControllerStatus.Stopped;
            foreach (ServiceController service in services)
            {
                if (service.ServiceName.ToString() == nomeServiço)
                {
                    stado = service.Status;
                    break;
                }
            }
            return stado;
        }

        public static bool ServInst(string nomeServiço)
        {
            bool res = false;
            ServiceController[] servicos = ServiceController.GetServices();
            foreach(ServiceController serv in servicos)
            {
                if(serv.ServiceName == nomeServiço)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public static string FormatarDataSQL(string data)
        {
            //Formato DD-MM-YYYY Para YYYY-MM-DD
            string dia = data.Substring(0, 2);
            string mes = data.Substring(3, 2);
            string ano = data.Substring(6, 4);
            string dataFormatada = String.Format("{0}-{1}-{2}", ano, mes, dia);
            return dataFormatada;
        }
    }
    
}
