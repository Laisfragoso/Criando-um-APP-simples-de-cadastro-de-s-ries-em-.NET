using  System ;

namespace  DIO . Series
{
     programa de aula
    {
         SerieRepositorio  repositorio  estático =  novo  SerieRepositorio ();
        static  void  Main ( string [] args )
        {
            string  opcaoUsuario  =  ObterOpcaoUsuario ();

			while ( opcaoUsuario . ToUpper () ! =  " X " )
			{
				switch ( opcaoUsuario )
				{
					caso  " 1 " :
						ListarSeries ();
						pausa ;
					caso  " 2 " :
						InserirSerie ();
						pausa ;
					caso  " 3 " :
						AtualizarSerie ();
						pausa ;
					caso  " 4 " :
						ExcluirSerie ();
						pausa ;
					caso  " 5 " :
						VisualizarSerie ();
						pausa ;
					caso  " C " :
						Console . Limpar ();
						pausa ;

					padrão :
						lance  novo  ArgumentOutOfRangeException ();
				}
				opcaoUsuario  =  ObterOpcaoUsuario ();
			}
			Console . WriteLine ( " Obrigado por utilizar nossos serviços. " );
			Console . ReadLine ();
        }

         string estática  privada ObterOpcaoUsuario () 
		{
			Console . WriteLine ();
			Console . WriteLine ( " Informe a opção escolha: " );

			Console . WriteLine ( " 1 - Listar séries " );
			Console . WriteLine ( " 2 - Inserir nova série " );
			Console . WriteLine ( " 3 - Atualizar série " );
			Console . WriteLine ( " 4 - Excluir série " );
			Console . WriteLine ( " 5 - Visualizar série " );
			Console . WriteLine ( " C - Limpar Tela " );
			Console . WriteLine ( " X - Sair " );
			Console . WriteLine ();

			string  opcaoUsuario  =  Console . ReadLine (). ToUpper ();
			Console . WriteLine ();
			
			return  opcaoUsuario ;
		}

        private  static  void  ListarSeries ()
		{
			Console . WriteLine ( " Listar séries " );

			var  lista  =  repositório . Lista ();

			if ( lista . Contagem  ==  0 )
			{
				Console . WriteLine ( " Nenhuma série cadastrada. " );
				retorno ;
			}

			foreach ( var  série  na  lista )
			{
                var  excluido  =  série . retornaExcluido ();
				Console . WriteLine ( " #ID {0}: - {1} {2} " , série . RetornaId (), série . RetornaTitulo (), ( excluido  ?  " * Excluído * "  :  " " ));
			}
		}

        privado  estático  void  InserirSerie ()
		{
			Console . WriteLine ( " Inserir nova série " );

			foreach ( int  i  in  Enum . GetValues ( typeof ( Genero )))
			{
				Console . WriteLine ( " {0} - {1} " , i , Enum . GetName ( typeof ( Genero ), i ));
			}

			Console . Write ( " Digite o gênero entre as opções acima: " );
			int  entradaGenero  =  int . Parse ( Console . ReadLine ());

			Console . Write ( " Digite o Título da Série: " );
			string  entradaTitulo  =  Console . ReadLine ();

			Console . Write ( " Digite o Ano de Início da Série: " );
			int  entradaAno  =  int . Parse ( Console . ReadLine ());

			Console . Write ( " Digite a Descrição da Série: " );
			string  entradaDescricao  =  Console . ReadLine ();

			Serie  novaSerie  =  nova  Serie ( id : repositorio . ProximoId (),
										genero : ( Genero ) entradaGenero ,
										titulo : entradaTitulo ,
										ano : entradaAno ,
										descricao : entradaDescricao );

			repositorio . Insere ( novaSerie );
		}

        private  static  void  AtualizarSerie ()
		{
			Console . Write ( " Digite o ID da série: " );
			int  indiceSerie  =  int . Parse ( Console . ReadLine ());

			foreach ( int  i  in  Enum . GetValues ( typeof ( Genero )))
			{
				Console . WriteLine ( " {0} - {1} " , i , Enum . GetName ( typeof ( Genero ), i ));
			}

			Console . Write ( " Digite o gênero entre as opções acima: " );
			int  entradaGenero  =  int . Parse ( Console . ReadLine ());

			Console . Write ( " Digite o Título da Série: " );
			string  entradaTitulo  =  Console . ReadLine ();

			Console . Write ( " Digite o Ano de Início da Série: " );
			int  entradaAno  =  int . Parse ( Console . ReadLine ());

			Console . Write ( " Digite a Descrição da Série: " );
			string  entradaDescricao  =  Console . ReadLine ();

			Serie  atualizaSerie  =  nova  Serie ( id : indiceSerie ,
										genero : ( Genero ) entradaGenero ,
										titulo : entradaTitulo ,
										ano : entradaAno ,
										descricao : entradaDescricao );

			repositorio . Atualiza ( indiceSerie , atualizaSerie );
		}

        private  static  void  ExcluirSerie ()
		{
			Console . Write ( " Digite o ID da série: " );
			int  indiceSerie  =  int . Parse ( Console . ReadLine ());

			repositorio . Exclui ( indiceSerie );
		}

        private  static  void  VisualizarSerie ()
		{
			Console . Write ( " Digite o ID da série: " );
			int  indiceSerie  =  int . Parse ( Console . ReadLine ());

			var  serie  =  repositorio . RetornaPorId ( indiceSerie );
			Console . WriteLine ( série );
		}
    }
}