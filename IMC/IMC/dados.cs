using System.Data;

namespace IMC
{
    class Dados
    {
        public static DataTable dt = null;

        public static void CriarTabela()
        {
            dt = new DataTable();
            //dt.Columns.Add("IMC");
            dt.Columns.Add(new DataColumn("Nome", typeof(string)));
            dt.Columns.Add(new DataColumn("IMC", typeof(string)));
            dt.Columns.Add(new DataColumn("Classificação", typeof(string)));
            dt.Rows.Clear();
        }
        public static DataTable InserirTabela(string nome,float imc, string classificacao)
        {
            if(dt!=null)
            {
                DataRow dr = dt.NewRow();
                dr["Nome"] = nome;
                dr["IMC"] = imc;
                dr["Classificação"] = classificacao;
                //dt.Rows.Add(dr);
                dt.Rows.InsertAt(dr, 0);
            }
            return dt;
        }
    }
}
