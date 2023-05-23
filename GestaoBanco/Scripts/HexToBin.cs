using System;

namespace Cryptography
{
    public class HexToBin
    {
        public static string ConverToBin(string hexa)
        {
            string binarioC = hexa.Replace(" ", "");

            string CharForChar = binarioC;
            string txt_hexadecimal = string.Empty;
            string[] armazenarIF = new string[2];
            string comparar;
            int contIF = 0;
            bool OnOff = false;

            foreach (char bin in CharForChar)
            {
                armazenarIF[contIF] = bin.ToString();

                if (contIF == 0)
                {
                    comparar = armazenarIF[0] + armazenarIF[1]; //Comp
                    if (comparar == "0")
                    {
                        txt_hexadecimal += "0000";
                    }
                    if (comparar == "1")
                    {
                        txt_hexadecimal += "0001";
                    }
                    if (comparar == "2")
                    {
                        txt_hexadecimal += "0010";
                    }
                    if (comparar == "3")
                    {
                        txt_hexadecimal += "0011";
                    }
                    if (comparar == "4")
                    {
                        txt_hexadecimal += "0100";
                    }
                    if (comparar == "5")
                    {
                        txt_hexadecimal += "0101";
                    }
                    if (comparar == "6")
                    {
                        txt_hexadecimal += "0110";
                    }
                    if (comparar == "7")
                    {
                        txt_hexadecimal += "0111";
                    }
                    if (comparar == "8")
                    {
                        txt_hexadecimal += "1000";
                    }
                    if (comparar == "9")
                    {
                        txt_hexadecimal += "1001";
                    }
                    if (comparar == "A")
                    {
                        txt_hexadecimal += "1010";
                    }
                    if (comparar == "B")
                    {
                        txt_hexadecimal += "1011";
                    }
                    if (comparar == "C")
                    {
                        txt_hexadecimal += "1100";
                    }
                    if (comparar == "D")
                    {
                        txt_hexadecimal += "1101";
                    }
                    if (comparar == "E")
                    {
                        txt_hexadecimal += "1110";
                    }
                    if (comparar == "F")
                    {
                        txt_hexadecimal += "1111";
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
            for (int i = 0; i < ((txt_hexadecimal.Length / 8)); i++)
            {
                montagem += txt_hexadecimal.Substring(a, 8) + " ";
                a += 8;
            }
            txt_hexadecimal = montagem;
            return txt_hexadecimal;
        }
    }
}
