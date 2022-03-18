using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classFuncionario

    { // CRIAR CONSTRUTOR DA CLASSE CLIENTE
      //PRECISA TER MENSMO NOME DA CLASSE
      // SERVE PARA INICIALIZAR AS PROPRIEDADE E METODOS
        public classFuncionario()

        {
            cod_func = 0;
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
            telefone = null;
            celular = null;
            status_func = 0;
            dt_cad = DateTime.Now;
            cod_carg = 0;

        }


        //CRIAR AS PROPRIEDADE
        //LER E GRAVAR AS INFORMAÇÕES NO BANCO DE DADOS
        //COLOCAR O MESMO NOME DOS CAMPOS DA TABELA DO BANCO
        //ATALHO PARA CRIAR UMA PROPRIEDADE É prop TAB TAB (2 vezes)
        //GET LÊ e SET FAZ.
        public int cod_func { get; set; }
        public string nome { get; set; }
        public DateTime datanascimento { get; set; }
        public string NomeCliente { get; set; }
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
        public string telefone { get; set; }
        public string celular { get; set; }
        public int status_func { get; set; }
        public int cod_carg { get; set; }


        public int CadastrarFuncionario()
        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "INSERT INTO Funcionario VALUES(0, '" + nome + "', '" + rg + "',  '" + cpf + "','" + datanascimento.ToString("yyyy-MM-dd") + "', '" + sexo + "' , '" + rua + "' , '" + numero + "' , '" + complemento + "' , '" + bairro + "', '" + cidade + "' , '" + estado + "' , '" + cep + "' , '" + email + "', '" + telefone + "', '" + celular + "', 1, now(), '" + cod_carg + "')";

            //CRIAR O OBJETO DA CLASSE CONEXÃO
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //metodo para carregar combo de funcionario no formulario livro add no projeto por daniela 22-11-21 (tabela nao era minha)
        public DataTable CarregarCbFuncionario()
        {
            string query = "SELECT cod_func,nome FROM funcionario WHERE status_func = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //metodos de consulta
        /*Metodos de  consulta de clientes*/
        /*consultar por nome(inicio e contem), sexo, status e cpf*/
        /*dados exibidos: cod, nome, cpf, telefones e data nascimento*/

        //metodo de consulta de cliente por nome INICIO
        public DataTable ConsultaFuncionarioNomeInicio(string nomeinicio)

        {
            string query = "SELECT funcionario.cod_func'Codigo', funcionario.nome'Nome', funcionario.cpf'CPF', funcionario.datanascimento'Data Nascimento', funcionario.telefone'Telefone', funcionario.celular'Celular', cargos.nome'Cargo' FROM funcionario JOIN cargos ON funcionario.cod_carg = cargos.cod_carg   WHERE funcionario.nome LIKE '" + nomeinicio + "%' AND funcionario.status_func = 1 ORDER BY funcionario.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //METODO DE CONSULTA DE FUNCIONARIO POR NOME CONTEM

        public DataTable ConsultaFuncionarioNomeContem(string nomecontem)
        {
            string query = "SELECT funcionario.cod_func'Codigo', funcionario.nome'Nome', funcionario.cpf'CPF', funcionario.datanascimento'Data Nascimento', funcionario.telefone'Telefone', funcionario.celular'Celular', cargos.nome'Cargo' FROM funcionario JOIN cargos ON funcionario.cod_carg = cargos.cod_carg  WHERE funcionario.nome LIKE '%" + nomecontem + "%' AND funcionario.status_func = 1 ORDER BY funcionario.nome";
            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }

        //METODO DE CONSULTA DE FUNCIONARIO POR CPF

        public DataTable ConsultaFuncionarioCPF(string cpf)
        {
            string query = "SELECT funcionario.cod_func'Codigo', funcionario.nome'Nome', funcionario.cpf'CPF', funcionario.datanascimento'Data Nascimento', funcionario.telefone'Telefone', funcionario.celular'Celular', cargos.nome'Cargo' FROM funcionario JOIN cargos ON funcionario.cod_carg = cargos.cod_carg  WHERE funcionario.cpf = '"+cpf+"' AND funcionario.status_func = 1 ORDER BY funcionario.nome";
            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }

        //METODO DE CONSULTA DE FUNCIONARIO POR SEXO

        public DataTable ConsulaFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.cod_func'Codigo', funcionario.nome'Nome', funcionario.cpf'CPF', funcionario.datanascimento'Data Nascimento', funcionario.telefone'Telefone', funcionario.celular'Celular', cargos.nome'Cargo' FROM funcionario JOIN cargos ON funcionario.cod_carg = cargos.cod_carg  WHERE funcionario.sexo = '" + sexo + "' AND funcionario.status_func = 1 ORDER BY funcionario.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //METODO DE CONSULTA DE FUNCIONARIO POR STATUS

        public DataTable ConsultaFuncionarioStatus(int status)

        {
            string query = "SELECT funcionario.cod_func, funcionario.nome, funcionario.cpf, funcionario.datanascimento, funcionario.telefone, funcionario.celular, cargos.nome'cargo' FROM funcionario JOIN cargos ON funcionario.cod_carg = cargos.cod_carg  WHERE funcionario.status_func = "+status+" ORDER BY funcionario.nome";

            classConexao classConexao = new classConexao();
            return classConexao.RetornaDataTable(query);
        }

        //METODO PARA BUSCAR OS DADOS DO BD QUANDO O USUARIO ESCOLHER O CLIENTE NA GRID

        public bool ConsultarFuncionario(int cod)
        {
            string query = "SELECT * FROM funcionario WHERE cod_func = " + cod + "";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                cod_func = Convert.ToInt32(dt.Rows[0]["cod_func"]);
                dt_cad = Convert.ToDateTime(dt.Rows[0]["dt_cad"]);
                nome = dt.Rows[0]["nome"].ToString();
                rg = dt.Rows[0]["rg"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                datanascimento = Convert.ToDateTime(dt.Rows[0]["datanascimento"]);
                sexo = dt.Rows[0]["sexo"].ToString();
                rua = dt.Rows[0]["rua"].ToString();
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = dt.Rows[0]["complemento"].ToString();
                bairro = dt.Rows[0]["bairro"].ToString();
                cidade = dt.Rows[0]["cidade"].ToString();
                estado = dt.Rows[0]["estado"].ToString();
                cep = dt.Rows[0]["cep"].ToString();
                email = dt.Rows[0]["email"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                celular = dt.Rows[0]["celular"].ToString();
                status_func = Convert.ToInt32(dt.Rows[0]["status_func"]);
                cod_carg = Convert.ToInt32(dt.Rows[0]["cod_carg"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        //METODO PARA ATUALIZAR CLIENTE

        public bool AtualizarFuncionario()

        {
            //CRIAR VARIAVEL QUE VAI RECEBER O COMANDO DO BD
            string query = "UPDATE  Funcionario SET nome = '" + nome + "', rg = '" + rg + "', cpf = '" + cpf + "', datanascimento = '" + datanascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "' , rua = '" + rua + "' , numero = '" + numero + "' , complemento = '" + complemento + "' , bairro = '" + bairro + "', cidade = '" + cidade + "' , estado = '" + estado + "' , cep = '" + cep + "' , email = '" + email + "', telefone = '" + telefone + "',  celular = '" + celular + "', status_func = " + status_func + " WHERE cod_func = " + cod_func + "";

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

        //METODO DE EXCLUIR FUNCIONARIO

        public bool ExcluirFuncionario()

        {
            string query = "DELETE FROM funcionario WHERE cod_func = " + cod_func + "";

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




        //carregar a combo da cidade no relatorio 
        public DataTable RelCarregarcidade()
        {
            string query = "SELECT DISTINCT cidade  FROM funcionario  WHERE status_func = 1 ORDER BY cidade";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR IDADE
        public DataTable RelFuncionarioidade(int idadeinicio, int idadefinal)
        {
            string query = "SELECT nome, cpf, datanascimento, sexo, cidade, telefone, celular, status_func FROM funcionario WHERE TIMESTAMPDIFF(YEAR, datanascimento, NOW()) BETWEEN " + idadeinicio + " AND " + idadefinal + "  AND status_func = 1 ORDER BY nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RELATORIO DE CLEINTE POR Aniversario dia mes
        public DataTable RelFuncionarioAniversarioDiaMes(int dia, int mes)
        {
            string query = "SELECT nome, cpf, datanascimento, telefone, celular, sexo, cidade, status_func FROM funcionario WHERE DAY(datanascimento) = " + dia + "  AND MONTH(datanascimento) = " + mes + " AND status_func = 1  ORDER BY nome";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR  mes
        public DataTable RelFuncionarioAniversariMes(int mes)
        {
            string query = "SELECT nome, cpf, datanascimento, telefone, celular, sexo, cidade, status_func FROM funcionario WHERE MONTH(datanascimento) = '" + mes + "' AND status_func = 1  ORDER BY nome";
            

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //RELATORIO DE CLEINTE POR CIDADE
        public DataTable RelFuncionarioCidade(string cidade)

        {
            string query = "SELECT nome, cpf, datanascimento, telefone, celular, sexo, cidade, status_func FROM funcionario WHERE cidade = '" + cidade + "'  AND  status_func = 1  ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        public DataTable RelFuncionarioStatus(int Status)

        {
            string query = "SELECT nome, cpf, datanascimento, telefone, celular, sexo, cidade, status_func FROM funcionario WHERE status_func =  " + Status + " ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        public DataTable RelFuncionarioSexo(string sexo)

        {
            string query = "SELECT nome, cpf, datanascimento, sexo, cidade, telefone, celular, status_func FROM funcionario WHERE sexo = '" + sexo + "'  AND status_func = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

    }
}

