class Programa{
   static void Main()
   {
    string[] mes = new string[12];
    mes[0] = "01.Janeiro - \ndia 01 Feriado";
    mes[1] = "02.Fevereiro - \ndia 28 (Feriado para Servidor Público)";
    mes[2] = "03.Março - \ndia 01 e 02 (Feriado para Servidor Público) \ndia 29 Evento";
    mes[3] = "04.Abril - \ndia 21 Feriado \ndia 01 ,15 e 17 Evento" ;
    mes[4] = "05.Maio - \ndia 01 Feriado \ndia 08 Evento";
    mes[5] = "06.Junho - \ndia 12 e 16 Evento";
    mes[6] = "07.Julho - \nNenhum evento";
    mes[7] = "08.Agosto - \ndia 14 Evento";
    mes[8] = "09.Setembro - \ndia 07 e 08 Feriado";
    mes[9] = "10.Outubro - \ndia 12 Feriado \ndia 15 e 28 Ponto Facultativo \ndia 17 Evento";
    mes[10] = "11.Novembro - \ndia 02 e 15 Feriado \ndia 20 Evento";
    mes[11] = "12.Dezembro - \ndia 25 Feriado \ndia 19 Evento";
    string[] validacao = {"número" , "número válido"};
    int[] nMes = {1,2,3,4,5,6,7,8,9,10,11,12};
    int i;
    
    string resposta ,  iteracao;
    bool testeLogico;
    int respostaConvertida;
    
    Console.WriteLine("! BUSCA DOS MESES !\nCALENDÁRIO CURITIBA ");

    do
    {
        i = 0;

        do
        {

            Console.Write($"\nDigite um {validacao[i]}:  ");
            resposta = Console.ReadLine();
            testeLogico = int.TryParse( resposta , out int procura);
            i = 1;

        }while( testeLogico == false );

        respostaConvertida = int.Parse(resposta);
            
        for(i = 0 ; i < mes.Length; i++)
        {
            if(respostaConvertida == nMes[i])
            {
                Console.WriteLine($"\n {mes[i]}");
            }
        }

        if(respostaConvertida > 13 || respostaConvertida < 1)
        {
            Console.WriteLine("\n! NENHUM MÊS CORRESPONDE AO NÚMERO DIGITADO !");
        }
        else if (respostaConvertida == 13)
        {
            Console.WriteLine("\nCALENDÁRIO COMPLETO");
            for(i = 0 ; i < mes.Length; i++)
            {
                Console.WriteLine($"\n{mes[i]}");
            }
        }

        Console.WriteLine("\nPARA REPETIR \nAperte ' S '");
        iteracao = Console.ReadLine();

    }while( iteracao == "s" || iteracao == "S");
   }
}


       /*Console.WriteLine("FOREACH");
        foreach( string meses in mes)
        {
            Console.WriteLine(meses);
        }*/