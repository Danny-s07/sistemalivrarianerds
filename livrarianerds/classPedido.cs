using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classPedido
    {

        // CRIAR CONSTRUTOR DA CLASSE CLIENTE
        //PRECISA TER MENSMO NOME DA CLASSE
        // SERVE PARA INICIALIZAR AS PROPRIEDADE E METODOS
        public classPedido()
        {
            cod_ped = 0;
            dt_cad = DateTime.Now;
            valor_total = 0;
            formapagt = null;
            desconto = 0;
            cod_cli = 0;
            cod_func = 0;
        }
        //propriedades
        //ler e gravar as informações no bd 
        //colocar o mesmo nome dos campos da tabela do bd
        //atalho para criar uma propriedade é Prop tab tab
        public int cod_ped { get; set; }
        public DateTime dt_cad { get; set; }

        public decimal valor_total { get; set; }

        public string formapagt { get; set; }

        public decimal desconto { get; set; }

        public int cod_cli { get; set; }

        public int cod_func { get; set; }


        //metodo para cadastrar venda usando executaqueryid (execute scalar)
        public bool CadastrarPedido()
        {
            string query = "INSERT INTO pedido VALUES(0,now(),'"+ valor_total.ToString().Replace(",",".")+"','"+formapagt+"','"+ desconto.ToString().Replace(",",".")+"',"+ cod_cli+","+cod_func+");SELECT LAST_INSERT_ID()";

            classConexao cConexao = new classConexao();
            cod_ped = 0;
            cod_ped = cConexao.ExecutaQueryID(query);

            if(cod_ped != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //codigos para exibicao de relatorios simples
         public DataTable RelPedidoFuncionario(int funcionario)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func',pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func WHERE pedido.cod_func = " + funcionario + " ORDER BY pedido.cod_ped";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }



        public DataTable RelPedidoCliente(int cliente)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func  WHERE pedido.cod_cli = " + cliente + " ORDER BY pedido.cod_ped";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //retornar as  vendas detalhadas por datas inicio e final
        public DataTable RelPedidoPeriodo(DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func WHERE CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //retornar as  vendas detalhadas por funcionario e periodo do funcionario
        public DataTable RelPedidoFuncionarioData(int funcionario, DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func',pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func  WHERE pedido.cod_func = " + funcionario + " AND CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //retornar as  vendas detalhadas por funcionario e periodo do funcionario
        public DataTable RelPedidoClienteData(int cliente, DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func  WHERE pedido.cod_cli = " + cliente + " AND CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }



    }
}
