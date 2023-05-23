using System;

namespace biblioteca.Scripts
{
    class Bin_Char
    {
        public static string BinToChar(string Binario)
        {
            Binario = Binario.Replace(" ", "");
            string res = string.Empty;
            string[] par = new string[8];
            int b = 0;

            for (int i = 0; i < Binario.Length / 8; i++)
            {
                string binarioPart = Binario.Substring(b, 8);
                for (int a = 0; a < 8; a++)
                {
                    par[a] = binarioPart.Substring(a, 1);
                }
                int r1 = Convert.ToInt32((int.Parse(par[7])) * Math.Pow(2, 0));
                int r2 = Convert.ToInt32((int.Parse(par[6])) * Math.Pow(2, 1));
                int r3 = Convert.ToInt32((int.Parse(par[5])) * Math.Pow(2, 2));
                int r4 = Convert.ToInt32((int.Parse(par[4])) * Math.Pow(2, 3));
                int r5 = Convert.ToInt32((int.Parse(par[3])) * Math.Pow(2, 4));
                int r6 = Convert.ToInt32((int.Parse(par[2])) * Math.Pow(2, 5));
                int r7 = Convert.ToInt32((int.Parse(par[1])) * Math.Pow(2, 6));
                int r8 = Convert.ToInt32((int.Parse(par[0])) * Math.Pow(2, 7));
                int soma = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8;
                char Caracter = Convert.ToChar(soma);
                res += Caracter;
                b += 8;
            }

            return res;
        }
        public static string CharToBin(string StringChar)
        {
            string s = StringChar;
            string ret = string.Empty;
            string controle = string.Empty;

            foreach (char c in s)
            {
                int asc = (int)c;
                controle = Convert.ToString(asc, 2) + " ";
                while (controle.Length < 9)
                {
                    controle = "0" + controle;
                }
                ret += controle;
            }

            string[] strBin = ret.Trim().Split(' ');
            string rec = string.Empty;

            foreach (string ele in strBin)
            {
                char car = (char)Convert.ToInt32(ele, 2);
                rec += car;
            }

            return ret;
        }
    }
}
