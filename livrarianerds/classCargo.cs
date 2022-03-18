using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classCargo
    {
        // CRIAR CONSTRUTOR DA CLASSE CLIENTE
        //PRECISA TER MENSMO NOME DA CLASSE
        // SERVE PARA INICIALIZAR AS PROPRIEDADE E METODOS
        public classCargo()

        {
            cod_carg = 0;
            nome = null;
            dt_cad = DateTime.Now;
            status_carg = 0;


        }

        //CRIAR AS PROPRIEDADE
        //LER E GRAVAR AS INFORMAÇÕES NO BANCO DE DADOS
        //COLOCAR O MESMO NOME DOS CAMPOS DA TABELA DO BANCO
        //ATALHO PARA CRIAR UMA PROPRIEDADE É prop TAB TAB (2 vezes)
        //GET LÊ e SET FAZ.
        public int cod_carg { get; set; }
        public string nome { get; set; }
        public DateTime dt_cad { get; set; }
        public int status_carg { get; set; }


        //CRIAR METODO DE CADASTRO DE CLIENTE
        //INSERT PRECISA SER FEITO NA MESMA ORDEM DO BANCO DE DADOS!!!

        public int CadastrarCargo()
        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "INSERT INTO cargos VALUES(0,'" + nome + "',now(),1)";

            //CRIAR O OBJETO DA CLASSE CONEXÃO
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //MÉTODO PARA CARREGAR COMBO DE CARGO NO FORMULARIO DE FUNCIONARIO
        public DataTable CarregarCbcargo()
        {
            /*SELECT PARA CARREGAR COMBO DE CARGO NO FORMULARIO DE FUNCIONARIO*/
            string query = "SELECT cod_carg, nome FROM cargos WHERE Status_carg = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //MÉTODOS DE RELATÓRIOS
        //RELATORIO SIMPLES  (SEM CONDIÇÃO / FILTRO) DE CARGO

        public DataTable RelCargo()
        {
            string query = "SELECT cargos.cod_carg, cargos.nome, cargos.dt_cad, cargos.status_carg FROM cargos ORDER BY nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


        //metodos de consulta
        /*Metodos de  consulta de clientes*/
        /*consultar por nome(inicio e contem), sexo, status e cpf*/
        /*dados exibidos: cod, nome, cpf, telefones e data nascimento*/

        //metodo de consulta de cliente por nome INICIO

        public DataTable ConsultaCargosNomeinicio(string nomeinicio)
        {
            string query = "SELECT cod_carg 'Codigo',nome 'Nome' FROM cargos WHERE cargos.nome LIKE  '" + nomeinicio + "%'  AND cargos.status_carg = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //METODO DE CONSULTA DE CLIENTE POR NOME CONTÉM

        public DataTable ConsultarCargosNomeContem(string nomecontem)
        {
            string query = "SELECT cod_carg 'Codigo',nome 'Nome' FROM cargos WHERE cargos.nome LIKE '%" + nomecontem + "%'  AND cargos.status_carg = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        public DataTable ConsultaCargosStatus(int status)

        {
            string query = "SELECT cargos.cod_carg 'Codigo', cargos.nome 'Nome' FROM cargos  WHERE cargos.status_carg = "+status+" ORDER BY cargos.nome";

            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }


        //METODO PARA BUSCAR OS DADOS DO BD QUANDO O USUARIO ESCOLHER O CLIENTE NA GRID

        public bool ConsultarCargos(int cod)
        {
            string query = "SELECT * FROM cargos WHERE cod_carg = " + cod + "";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_carg = Convert.ToInt32(dt.Rows[0]["cod_carg"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                nome = dt.Rows[0]["nome"].ToString();
                status_carg = Convert.ToInt32(dt.Rows[0]["status_carg"]);
                return true;
            }
            else
            {
                return false;
            }


        }


        //METODO PARA ATUALIZAR cargo

        public bool AtualizarCargos()

        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "UPDATE  cargos SET nome = '" + nome + "', status_carg = " + status_carg + " WHERE cod_carg = " + cod_carg + "";

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

        //METODO DE EXCLUIR CARGOS

        public bool ExcluirCargos()

        {
            string query = "DELETE FROM cargos WHERE cod_carg = " + cod_carg+ "";

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
    }
}

// inserido alguns nomes  em consultas para melhorar a exibição na grid das opções dos relatorios , Daniela 24-11-2021