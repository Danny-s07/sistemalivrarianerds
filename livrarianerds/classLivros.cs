using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classLivros
    {
        public classLivros()
        {
            cod_prod = 0;
            nome = null;
            qtd_estoque = 0;
            preco = 0;
            dt_cad = DateTime.Now;
            status_liv = 0;
            cod_forn = 0;
            cod_cat = 0;
            cod_aut = 0;
            
        }
        //propriedades
        //ler e gravar as informações no bd 
        //colocar o mesmo nome dos campos da tabela do bd
        //atalho para criar uma propriedade é Prop tab tab
        public int cod_prod { get; set; }
        public string nome { get; set; }
        public int qtd_estoque { get; set; }
        public decimal preco { get; set; }
        public DateTime dt_cad { get; set; }
        public int status_liv { get; set; }

        public int cod_forn { get; set; }

        public int cod_cat { get; set; }

        public int cod_aut { get; set; }


        public int CadastraLivros()
        {
            string query = "INSERT INTO livros VALUES(0,'" + nome + "','" + qtd_estoque + "','" + preco.ToString().Replace(",", ".") + "', now(), 1, '" + cod_forn + "','" + cod_cat + "', '"+ cod_aut +"')";



            //criar o objeto da classe conexao
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }


        //metodos de consulta
        /*Metodos de  consulta de livro*/
        /*consultar por nome(inicio e contem), codigo categoria , preco,status*/
        /*dados exibidos: cod, nome,estoque,valor, nome do fornecedor , nome da categoria ,*/

        public DataTable ConsultaLivroNomeInicio(string nomeinicio)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livro', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome 'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.nome LIKE '" + nomeinicio + "%' AND livros.status_liv = 1 ORDER BY livros.nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaLivroNomeContem(string nomecontem)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livro', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome 'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.nome LIKE '%" + nomecontem + "%' AND livros.status_liv = 1 ORDER BY livros.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaLivroStatus(int status)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livro', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome 'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.status_liv = " + status +" ORDER BY livros.nome; ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        } 


        public DataTable ConsultaLivroFornecedor(int fornecedor)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livrp', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome 'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE  livros.cod_forn = '" + fornecedor +"' and livros.status_liv = 1 ORDER BY livros.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        public DataTable ConsultaLivroCategoria(int categoria)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livro', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome 'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE  livros.cod_cat = '" + categoria + "' and livros.status_liv = 1 ORDER BY livros.nome; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaLivroPreco(decimal precoi, decimal precof)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Livro', livros.qtd_estoque 'Estoque',livros.preco 'Preço', categoria.nome  'Categoria',fornecedores.nome 'Fornecedor', autor.nome 'Autor(a)' FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut  WHERE livros.preco BETWEEN '" + precoi.ToString().Replace(",", ".") + "' AND '" + precof.ToString().Replace(",", ".") + "' and livros.status_liv = 1 ORDER BY livros.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodo para buscar os dados do bd quando o usuario escolher o cliente na grid
        public bool ConsultarLivro(int cod)
        {
            string query = "SELECT * FROM livros WHERE cod_prod = " + cod + "";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_prod = Convert.ToInt32(dt.Rows[0]["cod_prod"]);
                nome = dt.Rows[0]["nome"].ToString();
                qtd_estoque = Convert.ToInt32(dt.Rows[0]["qtd_estoque"]);
                preco = Convert.ToDecimal(dt.Rows[0]["preco"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                status_liv = Convert.ToInt32(dt.Rows[0]["status_liv"]);
                cod_forn = Convert.ToInt32(dt.Rows[0]["cod_forn"]);
                cod_cat = Convert.ToInt32(dt.Rows[0]["cod_cat"]);
                cod_aut = Convert.ToInt32(dt.Rows[0]["cod_aut"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        //metodo para atualizar livros

        public bool AtualizarLivro()
        {
            string query = "UPDATE livros SET nome = '" + nome + "', qtd_estoque = '" + qtd_estoque + "', preco = '" + preco.ToString().Replace(",", ".") + "', status_liv = "+status_liv+",cod_forn = '" + cod_forn + "', cod_cat = '" + cod_cat + "', cod_aut = " + cod_aut + " WHERE cod_prod = " + cod_prod+"";


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


        //meto de excluir cliente

        public bool ExcluirLivros()
        {
            string query = "DELETE FROM livros WHERE cod_prod = " + cod_prod + "";

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
        //relatorio por fornecedor fk
        public DataTable RelLivroFornecedor(int fornecedor)
        {

            string query = "SELECT  livros.nome, livros.qtd_estoque, livros.preco , fornecedores.nome 'cod_forn' , categoria.nome 'cod_cat', autor.nome 'cod_aut',livros.status_liv FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut  WHERE livros.cod_forn = " + fornecedor +" ORDER BY livros.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        //relatorio por categoria fk
        public DataTable RelLivroCategoria(int categoria)
        {
            string query = "SELECT  livros.nome, livros.qtd_estoque, livros.preco , fornecedores.nome 'cod_forn' , categoria.nome 'cod_cat', autor.nome 'cod_aut',livros.status_liv FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.cod_cat = " + categoria +" ORDER BY livros.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        //relatorio por status
        public DataTable RelLivroStatus(int status)
        {
            string query = "SELECT  livros.nome, livros.qtd_estoque, livros.preco , fornecedores.nome 'cod_forn' , categoria.nome 'cod_cat', autor.nome 'cod_aut',livros.status_liv FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.status_liv = " + status +" ORDER BY livros.nome ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //relatorio de preco
        public DataTable RelLivroPreco(decimal precoi, decimal precof)
        {
            string query = "SELECT livros.cod_prod, livros.nome, livros.qtd_estoque,livros.preco, categoria.nome 'cod_cat' ,fornecedores.nome 'cod_forn', autor.nome 'cod_aut',livros.status_liv FROM livros JOIN categoria ON livros.cod_cat = categoria.cod_cat JOIN fornecedores ON livros.cod_forn = fornecedores.cod_forn JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.preco BETWEEN '" + precoi.ToString().Replace(",", ".") + "' AND '" + precof.ToString().Replace(",", ".") + "' and livros.status_liv = 1 ORDER BY livros.nome;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        // metodo para trazer os livros no formulario de vendas
        public DataTable PesquisaLivrosVenda(string nome)
        {
            string query = "SELECT livros.cod_prod 'Codigo', livros.nome 'Nome', livros.qtd_estoque'Estoque',livros.preco 'Preço', autor.nome 'Autor(a)' FROM livros JOIN autor ON livros.cod_aut = autor.cod_aut WHERE livros.nome LIKE '%" + nome + "%' AND livros.status_liv = 1 ORDER BY livros.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        // METODOS QUE SAO USADOS NO FORMULARIO DE VENDA DE RELACAO NXN DAS TABELAS DO BD


        //metodo para atualizar qtde estoque quando uma venda é finalizada 
        public bool AtualizarQtde(int qtde, int cod)
        {
            string query = "UPDATE livros SET qtd_estoque = " + qtde + " WHERE cod_prod = "+ cod +"";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(query);
            if(resp ==1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //metodo para levar nome do produto para a lista de itens (grid de livros vendidos)

        public string BuscaNomeLivro(int cod)
        {
            string query = "SELECT nome 'Livros' FROM livros WHERE cod_prod = " + cod + "";


            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);
            if(dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["Livros"].ToString();
            }
            return nome;


        }


    }
}
