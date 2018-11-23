using System;
using System.Collections.Generic;

namespace questao02_produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        //List<Categoria> listaCategoria = new List<Categoria>();

        public Produto()
        {
        }
    }
}
