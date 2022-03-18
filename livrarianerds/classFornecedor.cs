using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classFornecedor
    {
        public classFornecedor()
        {
            cod_forn = 0;
            nome = null;
            sexo = null;
            email = null;
            cnpj = null;
            rua = null;
            numero = 0;
            bairro = null;
            cep = null;
            complemento = null;
            cidade = null;
            estado = null;
            telefone = null;
            celular = null;
            status_forn = 0;
            dt_cd = DateTime.Now;
         }
        //propriedades
        //ler e gravar as informações no bd 
        //colocar o mesmo nome dos campos da tabela do bd
        //atalho para criar uma propriedade é Prop tab tab
        public int cod_forn { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string email{ get; set; }
        public string cnpj { get; set; }
        public string rua { get; set; }

        public int numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public  string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public int status_forn { get; set; }
        public DateTime dt_cd { get; set; }

        public int CadastrarFornecedor()
        {

            //criar variavel que vai receber o comando do bd
            string query = "INSERT INTO fornecedores values(0,'" + nome + "', '" + sexo + "', '" + email + "','" + cnpj + "','" + rua + "','" + numero + "','" + bairro + "','" + cep + "','" + complemento + "','" + cidade + "','" + estado + "','" + telefone + "','" + celular + "', 1, now())";

            //criar o objeto da classe conexao
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        } 

        //metodo para carregar combo de fornecedores no formulario livro
        public DataTable CarregarCbFornecedores()
        {
            string query = "SELECT cod_forn,nome FROM fornecedores WHERE status_forn = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodos de consulta
        /*Metodos de  consulta de Fornecedores*/
        /*consultar por nome(inicio e contem), status, cidade e sexo*/
        /*dados exibidos: cod , nome , teleones , cidade*/

        //metodo de consulta de fornecedores por nome INICIO
        public DataTable ConsultaFornecedorNomeInicio(string nomeinicio)
        {
            string query = "SELECT fornecedores.cod_forn 'Codigo', fornecedores.nome 'Nome', fornecedores.telefone 'Telefone', fornecedores.celular 'Celular',fornecedores.cidade 'Cidade' FROM fornecedores WHERE fornecedores.nome LIKE '" + nomeinicio +"%' AND fornecedores.status_forn = 1 ORDER BY fornecedores.nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaFornecedorNomeContem(string nomecontem)
        {
            string query = "SELECT fornecedores.cod_forn'Codigo', fornecedores.nome'Nome', fornecedores.telefone'Telefone', fornecedores.celular'Celular',fornecedores.cidade'Cidade' FROM fornecedores WHERE fornecedores.nome LIKE '%" + nomecontem + "%' AND fornecedores.status_forn = 1 ORDER BY fornecedores.nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable ConsultaFornecedorCidade(string cidade)
        {
            string query = "SELECT fornecedores.cod_forn'Codigo', fornecedores.nome'Nome', fornecedores.telefone'Telefone', fornecedores.celular'Celular',fornecedores.cidade'Cidade' FROM fornecedores WHERE fornecedores.cidade = '" + cidade + "' AND fornecedores.status_forn = 1 ORDER BY fornecedores.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        } 

        public DataTable ConsultaFornecedorSexo(string sexo)
        {
            string query = "SELECT fornecedores.cod_forn'Codigo', fornecedores.nome'Nome', fornecedores.telefone'Telefone', fornecedores.celular'Celular',fornecedores.cidade'Cidade' FROM fornecedores WHERE fornecedores.sexo = '" + sexo +"' AND fornecedores.status_forn = 1 ORDER BY fornecedores.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        public DataTable CarregarCbCidade()
        {
            string query = "SELECT  DISTINCT cidade FROM fornecedores WHERE status_forn = 1 ORDER BY cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        public DataTable ConsultaFornecedorStatus(int status)
        {
            string query = "SELECT fornecedores.cod_forn, fornecedores.nome, fornecedores.telefone, fornecedores.celular,fornecedores.cidade FROM fornecedores WHERE fornecedores.status_forn = "+ status +" ORDER BY fornecedores.nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodo para buscar os dados do bd quando o usuario escolher um fornecedor  na grid

        public bool ConsultarFornecedor(int cod)
        {
            string query = "SELECT * FROM fornecedores WHERE fornecedores.cod_forn = "+ cod+ "";
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if(dt.Rows.Count > 0)
            {
                cod_forn = Convert.ToInt32(dt.Rows[0]["cod_forn"]);
                nome = dt.Rows[0]["nome"].ToString();
                sexo = dt.Rows[0]["sexo"].ToString();
                email = dt.Rows[0]["email"].ToString();
                cnpj = dt.Rows[0]["cnpj"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                bairro = dt.Rows[0]["bairro"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                complemento = dt.Rows[0]["complemento"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                celular = dt.Rows[0]["celular"].ToString();
                status_forn = Convert.ToInt32(dt.Rows[0]["status_forn"]);
                dt_cd = Convert.ToDateTime(dt.Rows[0]["dt_cd"]);
                 return true;

            }
            else
            {
                return false;
            }
        }

        //metodo para atualizar fornecedor
        public bool AtualizarFornecedor()
        {
            string query = "UPDATE fornecedores SET nome = '" + nome + "', sexo = '" + sexo + "', email = '" + email + "', cnpj ='" + cnpj + "', rua ='" + rua + "', numero = '" + numero + "', bairro = '" + bairro + "', cep = '" + cep + "', complemento = '" + complemento + "', cidade = '" + cidade + "', estado ='" + estado + "', telefone = '" + telefone + "', celular = '" + celular + "', status_forn = " + status_forn + " where cod_forn = '" + cod_forn + "' ";



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

        //metodo de excluir FORNECEDORES


        public bool ExcluirFornecedores()
        {
            string query = "DELETE FROM fornecedores WHERE cod_forn = " + cod_forn +" ";

            classConexao cConexao = new classConexao();

            int aux = cConexao.ExecutaQuery(query);
            if (aux !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable RelFornecedoresCidade(string cidade)
        {
            string query = "SELECT nome,cnpj, sexo, cidade, telefone , celular,status_forn FROM fornecedores WHERE cidade = '" + cidade +"' AND status_forn = 1 ORDER BY nome";
            
            
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelFornecedoresStatus(int status)
        {
            string query = "SELECT nome,cnpj, sexo, cidade, telefone , celular,status_forn FROM fornecedores WHERE  status_forn = " + status +" ORDER BY nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelFornecedorSexo(string sexo)
        {
            string query = "SELECT nome,cnpj, sexo, cidade, telefone , celular,status_forn FROM fornecedores WHERE sexo = '" + sexo +"' AND status_forn = 1 ORDER BY nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }


    }
}
