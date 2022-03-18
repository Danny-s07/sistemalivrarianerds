using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace livrarianerds
{
    class classRelVenda
    {
        public classRelVenda()
        {
            //tabela pedido
            cod_ped = 0;
            dt_cad = DateTime.Now;
            valor_total = 0;
            formapagt = null;
            desconto = 0;
            cod_cli = 0;
            cod_func = 0;

            //tabela itens vendidos
            codigo_itens_vendidos = 0;
            cod_prod = 0;
            qtde = 0;
            preco = 0;

        }
        //propriedade  do pedido
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

        //propriedade de itens vendidos

        public int codigo_itens_vendidos { get; set; }

         public int cod_prod { get; set; }

        public int qtde { get; set; }

        public decimal preco { get; set; }



        //metodos de relatorio

        //retornar as  vendas detalhadas por funcionario

        public DataTable RelVendaFuncionario(int funcionario)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', livros.nome'cod_prod',itens_vendidos.qtde, itens_vendidos.preco, pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func JOIN itens_vendidos ON itens_vendidos.cod_ped = pedido.cod_ped JOIN livros ON livros.cod_prod = itens_vendidos.cod_prod WHERE pedido.cod_func = " + funcionario + " ORDER BY pedido.cod_ped";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //retornar as  vendas detalhadas por funcionario e periodo do funcionario
        public DataTable RelVendaFuncionarioData(int funcionario, DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', livros.nome'cod_prod',itens_vendidos.qtde, itens_vendidos.preco, pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func JOIN itens_vendidos ON itens_vendidos.cod_ped = pedido.cod_ped JOIN livros ON livros.cod_prod = itens_vendidos.cod_prod WHERE pedido.cod_func = " + funcionario + " AND CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //retornar as  vendas detalhadas por datas inicio e final
        public DataTable RelVendaPeriodo(DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', livros.nome'cod_prod',itens_vendidos.qtde, itens_vendidos.preco, pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func JOIN itens_vendidos ON itens_vendidos.cod_ped = pedido.cod_ped JOIN livros ON livros.cod_prod = itens_vendidos.cod_prod WHERE CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }

        //retornar as  vendas detalhadas por cliente

        public DataTable RelVendaCliente(int cliente)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', livros.nome'cod_prod',itens_vendidos.qtde, itens_vendidos.preco, pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func JOIN itens_vendidos ON itens_vendidos.cod_ped = pedido.cod_ped JOIN livros ON livros.cod_prod = itens_vendidos.cod_prod WHERE pedido.cod_cli = " + cliente + " ORDER BY pedido.cod_ped";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //retornar as  vendas detalhadas por cliente e periodo do funcionario
        public DataTable RelVendaClienteData(int cliente, DateTime dinicio, DateTime dfinal)
        {
            string query = "SELECT pedido.cod_ped, pedido.dt_cad, cliente.nome 'cod_cli', funcionario.nome 'cod_func', livros.nome'cod_prod',itens_vendidos.qtde, itens_vendidos.preco, pedido.formapagt,pedido.desconto, pedido.valor_total FROM cliente JOIN pedido ON cliente.cod_cli = pedido.cod_cli JOIN funcionario ON funcionario.cod_func = pedido.cod_func JOIN itens_vendidos ON itens_vendidos.cod_ped = pedido.cod_ped JOIN livros ON livros.cod_prod = itens_vendidos.cod_prod WHERE pedido.cod_func = " + cliente + " AND CAST(pedido.dt_cad AS date) BETWEEN '" + dinicio.ToString("yyyy-MM-dd") + "' AND '" + dfinal.ToString("yyyy-MM-dd") + "'ORDER BY pedido.cod_ped";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
