using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IMC
{
    class GravarTexto
    {
        public bool GravaTexto(string texto)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"" + Directory.GetCurrentDirectory() + "\\dados.txt", true);
                using (writer)
                {
                    writer.WriteLine(texto);
                }
                return true;
            }
            catch { return false; }
        }
        public bool lerTexto()
        {
            try
            {
                StreamReader reader = new StreamReader(@"" + Directory.GetCurrentDirectory() + "\\dados.txt", true);
                using (reader)
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] l = linha.Split(';');
                        Dados.InserirTabela(l[0], float.Parse(l[1]), l[2]);
                    }
                }
                return true;
            }
            catch { return false; }


        }
    }
}

    




