using System.Data;

namespace IMC
{
    static class dados //deixando ela static a dados.cs sempre estará disponivel 
    {
        public static DataTable dt=null;
        //criar o metodo quando iniciar o sistema ele criar o data table
        public static void CriarTabela()
        {
            dt = new DataTable();
           // dt.Columns.Add("IMC"); sem tipagem
            dt.Columns.Add(new DataColumn("Nome", typeof(string)));
            dt.Columns.Add(new DataColumn("IMC", typeof(string)));
            dt.Columns.Add(new DataColumn("Classificação", typeof(string)));
            dt.Rows.Clear();//chamar o datatable e limpar dados
        }
        public static DataTable InserirTabela(string nome, float imc, string classificacao)
        {
            //verificar se o data table esta disponível para salvar dados
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["Nome"] = nome;
                dr["IMC"] = imc;
                dr["Classificação"] = classificacao;
                //dt.Rows.Add(dr);
                dt.Rows.InsertAt(dr, 0);//insert at insere onde eu quero
            }
            return dt;
        }

    }
}
