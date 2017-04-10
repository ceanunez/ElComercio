using System;

namespace Pregunta1
{
    public class ChangeString
    {
        private String alfabeto = "abcdefghijklmnñopqrstuvwxyz";
        
        public string build(String inString) {
            String outString = String.Empty;
            foreach (char a in inString.ToCharArray()) {
                if (alfabeto.IndexOf(a) == alfabeto.Length -1)
                {
                    outString += alfabeto.ToCharArray()[0];
                }
                else
                {
                    if (alfabeto.IndexOf(a) == -1)
                        outString += a;
                    else
                        outString += alfabeto.ToCharArray()[alfabeto.IndexOf(a) + 1];
                }
            }

            return outString;
        }
    }
}
