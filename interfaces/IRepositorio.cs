usando o  sistema . Coleções . Genérico ;

namespace  DIO . Series . Interfaces
{
     interface  pública IRepositorio < T >
    {
        Lista < T > Lista ();
        T  RetornaPorId ( int  id );        
        void  Insere ( T  entidade );        
        void  Exclui ( int  id );        
        void  Atualiza ( int  id , T  entidade );
        int  ProximoId ();
    }
}