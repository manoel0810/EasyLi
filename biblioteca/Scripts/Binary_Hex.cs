using System;

namespace biblioteca.Scripts
{
    public class Binary_Hex
    {
        public static string ConvertToBin(string completa)
        {
            string s = completa;
            string ret = "";
            string controle = "";

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
            string rec = "";

            foreach (string ele in strBin)
            {
                char car = (char)Convert.ToInt32(ele, 2);
                rec += car;
            }

            return ret;
        }

        public static string ConverToHex(string binario)
        {
            string binarioC = binario.Replace(" ", "");

            string CharForChar = binarioC;
            string txt_hexadecimal = string.Empty;
            string[] armazenarIF = new string[4];
            string comparar;
            int contIF = 0;
            bool OnOff = false;

            foreach (char bin in CharForChar)
            {
                armazenarIF[contIF] = bin.ToString();

                if (contIF == 3)
                {
                    comparar = armazenarIF[0] + armazenarIF[1] + armazenarIF[2] + armazenarIF[3]; //+ armazenarIF[4];
                    if (comparar == "0000")
                    {
                        txt_hexadecimal += "0";
                    }
                    if (comparar == "0001")
                    {
                        txt_hexadecimal += 1;
                    }
                    if (comparar == "0010")
                    {
                        txt_hexadecimal += 2;
                    }
                    if (comparar == "0011")
                    {
                        txt_hexadecimal += 3;
                    }
                    if (comparar == "0100")
                    {
                        txt_hexadecimal += 4;
                    }
                    if (comparar == "0101")
                    {
                        txt_hexadecimal += 5;
                    }
                    if (comparar == "0110")
                    {
                        txt_hexadecimal += 6;
                    }
                    if (comparar == "0111")
                    {
                        txt_hexadecimal += 7;
                    }
                    if (comparar == "1000")
                    {
                        txt_hexadecimal += 8;
                    }
                    if (comparar == "1001")
                    {
                        txt_hexadecimal += 9;
                    }
                    if (comparar == "1010")
                    {
                        txt_hexadecimal += "A";
                    }
                    if (comparar == "1011")
                    {
                        txt_hexadecimal += "B";
                    }
                    if (comparar == "1100")
                    {
                        txt_hexadecimal += "C";
                    }
                    if (comparar == "1101")
                    {
                        txt_hexadecimal += "D";
                    }
                    if (comparar == "1110")
                    {
                        txt_hexadecimal += "E";
                    }
                    if (comparar == "1111")
                    {
                        txt_hexadecimal += "F";
                    }
                    contIF = 0;
                    comparar = "";
                    OnOff = true;
                }
                contIF++;
                if (OnOff == true)
                {
                    contIF = 0;
                }
                else
                {
                    OnOff = false;
                }
                OnOff = false;
            }

            string montagem = string.Empty;
            int a = 0;
            for (int i = 0; i < ((txt_hexadecimal.Length / 2)); i++)
            {
                montagem += txt_hexadecimal.Substring(a, 2) + " ";
                a += 2;
            }
            txt_hexadecimal = montagem;
            return txt_hexadecimal;
        }
    }
}
