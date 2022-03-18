using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livrarianerds
{
    class classItensVendidos
    {
        // CRIAR CONSTRUTOR DA CLASSE CLIENTE
        //PRECISA TER MENSMO NOME DA CLASSE
        // SERVE PARA INICIALIZAR AS PROPRIEDADE E METODOS

        public classItensVendidos()
        {
            codigo_itens_vendidos = 0;
            cod_ped = 0;
            cod_prod = 0;
            qtde = 0;
            preco = 0;
        }

        //propriedades
        //ler e gravar as informações no bd 
        //colocar o mesmo nome dos campos da tabela do bd
        //atalho para criar uma propriedade é Prop tab tab

        public int codigo_itens_vendidos { get; set; }

        public int cod_ped { get; set; }

        public int cod_prod { get; set; }

        public int qtde { get; set; }

        public decimal preco { get; set; }


        //metodo para cadastrar itens vendidos
        public bool CadastrarItensVendidos()
        {
            string query = "INSERT INTO itens_vendidos VALUES(0, " + cod_ped + ", " + cod_prod + ", " + qtde + "," + preco.ToString().Replace(",", ".") + ")";

            classConexao cConecxao = new classConexao();

            int aux = cConecxao.ExecutaQuery(query);

            if(aux != 0)
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
