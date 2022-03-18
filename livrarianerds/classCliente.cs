using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classCliente
    {
        // CRIAR CONSTRUTOR DA CLASSE CLIENTE
        //PRECISA TER MENSMO NOME DA CLASSE
        // SERVE PARA INICIALIZAR AS PROPRIEDADE E METODOS

        public classCliente()
        {
            cod_cli = 0;
            dt_cad = DateTime.Now;
            nome = null;
            rg = null;
            cpf = null;
            datanascimento = DateTime.Now;
            sexo = null;
            rua = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            email = null;
            telefones = null;
            celular = null;
            status_cli = 0;

        }

        public int cod_cli { get; set; }
        public string nome { get; set; }
        public DateTime datanascimento { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public DateTime dt_cad { get; set; }
        public string sexo { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string telefones { get; set; }
        public string celular { get; set; }
        public int status_cli { get; set; }



        //CRIAR METODO DE CADASTRO DE CLIENTE
        //INSERT PRECISA SER FEITO NA MESMA ORDEM DO BANCO DE DADOS!!!

        public int CadastrarCliente()
        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "INSERT INTO Cliente VALUES(0,now(), '" + nome + "', '" + rg + "',  '" + cpf + "','" + datanascimento.ToString("yyyy-MM-dd") + "', '" + sexo + "' , '" + rua + "' , '" + numero + "' , '" + complemento + "' , '" + bairro + "', '" + cidade + "' , '" + estado + "' , '" + cep + "' , '" + email + "', '" + telefones + "', '" + celular + "', 1)";

            //CRIAR O OBJETO DA CLASSE CONEXÃO
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //metodo para carregar combo de funcionario no formulario livro add no projeto por daniela 28-11-21 (tabela nao era minha)
        public DataTable CarregarCbCliente()
        {
            string query = "SELECT cod_cli,nome FROM cliente WHERE status_cli = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        //METODO DE CONSULTA
        /*Metodos de  consulta de clientes*/
        /*consultar por nome(inicio e contem), sexo, status e cpf*/
        /*dados exibidos: cod, nome, cpf, telefones e data nascimento*/
        //metodo de consulta de cliente por nome INICIO

        public DataTable ConsultaClienteNomeInicio(string nomeinicio)

        {
          string query = "SELECT cod_cli'Codigo', nome'Nome', cpf'CPF', datanascimento'Data Nascimento', telefones'Telefone', celular'Celular' FROM cliente WHERE nome LIKE '"+ nomeinicio + "%' AND status_cli = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //METODO DE CONSULTA DE CLIENTE POR NOME CONTEM

        public DataTable ConsultaClienteNomeContem(string nomecontem)
        {
           string query = "SELECT cod_cli 'Codigo', nome'Nome', cpf 'CPF', datanascimento 'Data nascimento', telefones 'Telefone', celular'Celular' FROM cliente WHERE nome LIKE '%" + nomecontem+"%' AND status_cli = 1 ORDER BY nome";
            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }


        //METODO DE CONSULTA DE CLIENTE POR CPF

        public DataTable ConsultaClienteCPF(string cpf)
        {
            string query = "SELECT cod_cli 'Codigo', nome 'Nome', cpf 'CPF', datanascimento 'Data Nascimento', telefones 'Telefone', celular 'Celular' FROM cliente WHERE cpf = '" + cpf + "' AND status_cli = 1 ORDER BY nome";
            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }

        //METODO DE CONSULTA DE CLIENTE POR SEXO

        public DataTable ConsulaClineteSexo(string sexo)
        {
            string query = "SELECT cod_cli 'Codigo', nome 'Nome', cpf 'CPF', datanascimento 'Data Nascimento', telefones 'Telefone', celular'Celular' FROM cliente WHERE sexo= '" + sexo + "' AND status_cli = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //METODO DE CONSULTA DE CLIENTE POR STATUS

        public DataTable ConsultaClienteStatus(int status)

        {
            string query = "SELECT cod_cli 'Codigo', nome 'Nome', cpf 'CPF', datanascimento 'Data Nascimento', telefones 'Telefone', celular 'Celular' FROM cliente WHERE status_cli = "+status+" = 1 ORDER BY nome";

            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }

        //METODO PARA BUSCAR OS DADOS DO BD QUANDO O USUARIO ESCOLHER O CLIENTE NA GRID

        public bool ConsultarCliente(int cod)
        {
            string query = "SELECT * FROM cliente WHERE cod_cli = " + cod + "";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_cli = Convert.ToInt32(dt.Rows[0]["cod_cli"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                nome = dt.Rows[0]["nome"].ToString();
                rg = dt.Rows[0]["RG"].ToString();
                cpf = dt.Rows[0]["CPF"].ToString();
                datanascimento = Convert.ToDateTime(dt.Rows[0]["datanascimento"]);
                sexo = dt.Rows[0]["Sexo"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                email = dt.Rows[0]["email"].ToString();
                telefones =  dt.Rows[0]["telefones"].ToString();
                celular = dt.Rows[0]["celular"].ToString();
                status_cli = Convert.ToInt32(dt.Rows[0]["status_cli"]);
                return true;
                                                                                                            }
            else
            {
                return false;
            }
                                 
        }

        //METODO PARA ATUALIZAR CLIENTE

        public bool AtualizarCliente()

        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "UPDATE  Cliente SET nome = '" + nome + "', rg = '" + rg + "', cpf = '" + cpf + "', datanascimento = '" + datanascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "' , rua = '" + rua + "' , numero = '" + numero + "' , complemento = '" + complemento + "' , bairro = '" + bairro + "', cidade = '" + cidade + "' , estado = '" + estado + "' , cep = '" + cep + "' , email = '" + email + "', telefones = '" + telefones + "',  celular = '" + celular + "', status_cli = " + status_cli + " WHERE cod_cli = " + cod_cli + "";

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

        //METODO DE EXCLUIR CLIENTE

        public bool ExcluirCliente()

        {
            string query = "DELETE FROM cliente WHERE cod_cli = " + cod_cli + "";

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

               
        //carregar a combo da cidade no relatorio 
        public DataTable RelCarregarcidade()
        {
            string query = "SELECT DISTINCT cidade  FROM cliente  WHERE status_cli = 1 ORDER BY cidade";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR IDADE
        public DataTable RelClienteidade(int idadeinicio, int idadefinal)
        {
            string query = "SELECT nome, cpf, datanascimento, sexo, cidade, telefones, celular, status_cli FROM cliente WHERE TIMESTAMPDIFF(YEAR, datanascimento, NOW()) BETWEEN " + idadeinicio + " AND " + idadefinal + "  AND status_cli = 1 ORDER BY nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RELATORIO DE CLEINTE POR Aniversario dia mes
        public DataTable RelClienteAniversarioDiaMes(int dia, int mes)
        {
            string query = "SELECT nome, cpf, datanascimento, telefones, celular, sexo, cidade, status_cli FROM cliente WHERE DAY(datanascimento) = " + dia + "  AND MONTH(datanascimento) = " + mes + " AND status_cli = 1  ORDER BY nome";

            
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR  mes
        public DataTable RelClienteAniversariMes(int mes)
        {
            string query = "SELECT nome, cpf, datanascimento, telefones, celular, sexo, cidade, status_cli FROM cliente WHERE MONTH(datanascimento) = '" + mes + "' AND status_cli = 1  ORDER BY nome";



            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR CIDADE
        public DataTable RelClienteCidade(string cidade)

        {
            string query = "SELECT nome, cpf, datanascimento, telefones, celular, sexo, cidade, status_cli FROM cliente WHERE cidade = '" + cidade + "'  AND  status_cli = 1  ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelClienteStatus(int Status)

        {
            string query = "SELECT nome, cpf, datanascimento, telefones, celular, sexo, cidade, status_cli FROM cliente WHERE status_cli =  " + Status + " ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        public DataTable RelClienteSexo(string sexo)

        {
            string query = "SELECT nome, cpf, datanascimento, sexo, cidade, telefones, celular, status_cli FROM cliente WHERE sexo = '" + sexo + "'  AND status_cli = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //pesquisa do formulario de vendas cliente criado por Daniela  22-11-2021
        public DataTable PesquisaClienteVendas(string nome)

        {
            string query = "SELECT cod_cli 'Codigo', nome 'Nome', cpf 'CPF' FROM cliente WHERE nome LIKE '%" + nome + "%' AND status_cli = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

    }
}

// inserido alguns nomes  em consultas para melhorar a exibição na grid das opções dos relatorios , Daniela 24-11-2021