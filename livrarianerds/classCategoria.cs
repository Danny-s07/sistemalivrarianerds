using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classCategoria
    {
        public classCategoria()
        {
            cod_cat = 0;
            nome = null;
            dt_cad = DateTime.Now;
            status_cat = 0;
        }

        //propriedades de leitura e gravacao
        public int cod_cat { get; set; }
        public string nome { get; set; }
        public DateTime dt_cad { get; set; }
        public int status_cat { get; set; }

        //criar metodo de cadastro de cliente 
        //insert precisa ser feito nas mesma ordem do bd 
        public int CadastrarCategoria()
        {
            string query = "INSERT INTO Categoria values(0,'" + nome + "', now(),1)";


            //criar o objeto da classe conexao
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }
        //metodos de consulta
        /*Metodos de  consulta de autores*/
        /*consultar por nome(inicio e contem), sexo, status */
        /*dados exibidos: cod, nome, telefones */

        //metodo de consulta de autor por nome INICIO
        public DataTable ConsultaCategoriaNomeInicio(string nomeinicio)
        {
            string query = "SELECT categoria.cod_cat 'Codigo', categoria.nome 'Nome' FROM categoria WHERE categoria.nome LIKE '" + nomeinicio + "%' AND categoria.status_cat= 1 ORDER BY categoria.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //metodo de consulta de autor por nome CONTEM
        public DataTable ConsultaCategoriaNomeContem(string nomecontem)
        {
            string query = "SELECT categoria.cod_cat 'Codigo', categoria.nome 'Nome' FROM categoria WHERE categoria.nome LIKE '%" + nomecontem + "%' AND categoria.status_cat= 1 ORDER BY categoria.nome ";



            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodo de consulta de autores por status
        public DataTable ConsultaAutoresStatus(int status)
        {
            string query = "SELECT categoria.cod_cat 'Codigo', categoria.nome 'Nome' FROM categoria WHERE categoria.status_cat = " + status + " ORDER BY categoria.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        public DataTable CarregarCbCategoria()
        {
            string query = "SELECT cod_cat,nome FROM categoria WHERE status_cat = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        //metodo para buscar os dados do bd quando o usuario escolher o autor na grid

        public bool ConsultarCategoria(int cod)
        {
            string query = "SELECT * FROM categoria WHERE categoria.cod_cat = " + cod + "";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_cat = Convert.ToInt32(dt.Rows[0]["cod_cat"]);
                nome = dt.Rows[0]["nome"].ToString();
                status_cat= Convert.ToInt32(dt.Rows[0]["status_cat"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        //metodo para atualizar categoria
        public bool AtualizarCategoria()
        {

            string query = "UPDATE categoria SET nome ='" + nome + "', status_cat = " + status_cat + " WHERE categoria.cod_cat = '" + cod_cat + "' ";

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
        //metodo de excluir autores

        public bool ExcluirCategoria()
        {
            string query = "DELETE FROM categoria WHERE cod_cat = " + cod_cat + "";


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


        //metodos de relatorio
        //relatorio simples (sem condição ou filtro) de categoria

        public DataTable RelCategoria()
        {
            string query = "SELECT cod_cat , nome , dt_cad , status_cat FROM categoria ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

















    }
}
