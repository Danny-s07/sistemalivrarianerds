using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classAutores
    {
        public classAutores(){
            cod_aut = 0;
            nome = null;
            telefone = null;
            celular = null;
            email = null;
            sexo = null;
            status_aut = 0;
            dt_cad = DateTime.Now;

         }
        //criando as propriedades
        public int cod_aut { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public int status_aut { get; set; }
        public DateTime dt_cad { get; set; }

        //criar metodo de cadastro de cliente 
        //insert precisa ser feito nas mesma ordem do bd 
        public int CadastrarAutor()
        {
            string query = "Insert into autor values(0,'" + nome + "','" + telefone + "', '" + celular + "', '" + email + "', '"+ sexo+"', 1, now())";



            //criar o objeto da classe conexao
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }


        //metodo para carregar combo de fornecedores no formulario livro
        public DataTable CarregarCbAutores()
        {
            string query = "SELECT cod_aut,nome FROM autor WHERE status_aut = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //metodos de consulta
        /*Metodos de  consulta de autores*/
        /*consultar por nome(inicio e contem), sexo, status */
        /*dados exibidos: cod, nome, telefones */

        //metodo de consulta de autor por nome INICIO
        public DataTable ConsultaAutoresNomeInicio(string nomeinicio)
        {
            string query = "SELECT autor.cod_aut'Codigo', autor.nome'Nome', autor.telefone'Telefone', autor.celular'Celular' FROM autor WHERE autor.nome LIKE '"+ nomeinicio +"%' AND autor.status_aut = 1 ORDER BY autor.nome";

             classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //metodo de consulta de autor por nome CONTEM
        public DataTable ConsultaAutoresNomeContem(string nomecontem)
        {
            string query = "SELECT autor.cod_aut'Codigo', autor.nome'Nome', autor.telefone'Telefone', autor.celular FROM autor WHERE autor.nome LIKE '%"+ nomecontem +"%' AND autor.status_aut = 1 ORDER BY autor.nome ";



            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodo de consulta de autores por sexo
        public DataTable ConsultaAutoresSexo(string sexo)
        {
            string query = "SELECT autor.cod_aut'Codigo', autor.nome'Nome', autor.telefone'Telefone', autor.celular'Celular' FROM autor WHERE autor.sexo = '"+ sexo +"'  AND autor.status_aut = 1 ORDER BY autor.nome ";

             classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //metodo de consulta de autores por status
        public DataTable ConsultaAutoresStatus(int status)
        {
            string query = "SELECT autor.cod_aut'Codigo', autor.nome'Nome', autor.telefone'Telefone', autor.celular'Celular' FROM autor WHERE autor.status_aut = "+ status +" ORDER BY autor.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodo para buscar os dados do bd quando o usuario escolher o autor na grid

        public bool ConsultarAutores(int cod)
        {
            string query = "SELECT * FROM autor WHERE autor.cod_aut = "+ cod +"";
            
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_aut = Convert.ToInt32(dt.Rows[0]["cod_aut"]);
                nome = dt.Rows[0]["nome"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                celular = dt.Rows[0]["celular"].ToString();
                email = dt.Rows[0]["email"].ToString();
                sexo = dt.Rows[0]["sexo"].ToString();
                status_aut = Convert.ToInt32(dt.Rows[0]["status_aut"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                return true;
            }
            else
            {
                return false;
            }

         }

        //metodo para atualizar autores
        public bool AtualizarAutores()
        {

            string query = "UPDATE autor SET nome ='" + nome + "', telefone ='" + telefone + "', celular ='" + celular + "', email ='" + email + "', sexo ='" + sexo + "', status_aut = " + status_aut + " WHERE autor.cod_aut = '"+ cod_aut + "' ";

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if ( aux != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo de excluir autores

        public bool ExcluirAutores()
        {
            string query = "DELETE FROM autor WHERE cod_aut = "+ cod_aut +"";


            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);

            if (aux != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable RelAutorSexo(string sexo)
        {

            string query = "SELECT nome, sexo, telefone, celular, status_aut FROM autor WHERE sexo = '"+sexo+"' AND status_aut = 1";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelAutorStatus(int status)
        {
            string query = "SELECT nome, sexo, telefone, celular, status_aut FROM autor WHERE status_aut = "+ status+"";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

         public DataTable RelAutorDataCadastro( DateTime datacadastroi , DateTime datacadastrof)
        {
            string query = " SELECT nome, sexo, telefone, celular, status_aut FROM autor WHERE CAST(dt_cad as date)  BETWEEN '" + datacadastroi.ToString("yyyy-MM-dd")+ "' AND '" + datacadastrof.ToString("yyyy-MM-dd") + "' AND status_aut = 1";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

                          








    }
}
