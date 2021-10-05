 using  System ;

namespace  meuprimeiroprojto
{
     programa de aula
    {
        static  void  Main ( string [] args )
        {
               string [] alunosams =  nova  string [ 5 ] {
               
               " Dani " ,
               " Maju " ,
               " Bruno " ,
               " Ramon " ,
               " Sofi "
            };
           Console . WriteLine ( alunosams [ 2 ]);

            for ( int  i  =  0 ; i  <  alunosams . Comprimento ; i ++ )
            {
                Console . WriteLine ( $ " Os alunos chamados são: { alunosams [ i ]} " );
            }
        }
    }
}