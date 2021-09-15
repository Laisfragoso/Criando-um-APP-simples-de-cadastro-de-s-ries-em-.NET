using  System ;
usando o  sistema . Coleções . Genérico ;
usando  DIO . Series . Interfaces ;

namespace  DIO . Series
{
	public  class  SerieRepositorio : IRepositorio < Serie >
	{
         Lista privada < Série > listaSerie  =  nova  Lista < Série > ();
		
		public  void  Atualiza ( int  id , Serie  objeto )
		{
			listaSerie [ id ] =  objeto ;
		}

		public  void  Exclui ( int  id )
		{
			listaSerie [ id ]. Excluir ();
		}

		public  void  Insere ( Serie  objeto )
		{
			listaSerie . Adicionar ( objeto );
		}

		 Lista pública < Série > Lista ()
		{
			return  listaSerie ;
		}

		public  int  ProximoId ()
		{
			retornar  listaSerie . Contar ;
		}

		public  Serie  RetornaPorId ( int  id )
		{
			retornar  listaSerie [ id ];
		}
	}
}