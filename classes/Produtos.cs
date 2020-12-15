using System;

namespace Metodos_Construtores2.classes
{
    public class Produto
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Descricao {get; set;}
        public int Estoque {get; set;}

        //Método Construtor
        public Produto(){
            
        }
    
        public Produto(int codigo){
            Codigo = codigo;
        
        }
        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome= Nome;
            Descricao = descricao;
            Estoque = estoque;
        }

    }
}