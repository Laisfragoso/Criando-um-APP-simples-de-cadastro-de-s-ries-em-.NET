using  System ;

namespace  DIO . Series
{
    public  class  Serie : EntidadeBase
    {
        // Atributos
		privado  Genero  Genero { get ; definir ; }
		 string  privada Titulo { get ; definir ; }
		 string  privada Descricao { get ; definir ; }
		private  int  Ano { get ; definir ; }
         bool  privado Excluido { get ; definir ; }

        // Métodos
		public  Serie ( int  id , Genero  genero , string  titulo , string  descricao , int  ano )
		{
			isso . Id  =  id ;
			isso . Genero  =  genero ;
			isso . Titulo  =  titulo ;
			isso . Descricao  =  descricao ;
			isso . Ano  =  ano ;
            isso . Excluido  =  falso ;
		}

         string de substituição  pública ToString () 
		{
            string  retorno  =  " " ;
            
			retorno  + =  " Gênero: "  +  isso . Genero  +  Environment . NewLine ;
            retorno  + =  " Titulo: "  +  isso . Titulo  +  Meio Ambiente . NewLine ;
            retorno  + =  " Descrição: "  +  isso . Descricao  +  Ambiente . NewLine ;
            retorno  + =  " Ano de Início: "  +  this . Ano  +  Meio Ambiente . NewLine ;
            retorno  + =  " Excluido: "  +  isso . Excluido ;
			
			return  retorno ;
		}

        public  string  retornaTitulo ()
		{
			devolva  isso . Titulo ;
		}

		public  int  retornaId ()
		{
			devolva  isso . Id ;
		}

         bool  público retornaExcluido ()
		{
			devolva  isso . Excluido ;	
		}

        public  void  Excluir () {
            isso . Excluido  =  verdadeiro ;
        }
    }
}