using System;
using System.Collections.Generic;
using System.Globalization;


namespace fixacao01.dominio
{
    class Produto : IComparable
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + descricao
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

        public int CompareTo(object obj)
        {
            Produto outroProduto = (Produto)obj;

            // Se os dois itens comparados forem iguais, retorna ZERO;
            // Se o primeiro for menor que o segundo, retorna um valor NEGATIVO;
            // Se o primeiro for maior que o segundo, retorna um valor POSITIVO;
            int resultado = descricao.CompareTo(outroProduto.descricao);
            if(resultado != 0 )
            {
                return resultado;
            }
            else
            {
                return -preco.CompareTo(outroProduto.preco);
            }
        }
    }
}
