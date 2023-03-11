using System;
using System;

public class Agendamento
{
    public int escolha;

    public void dataAgenda()
    {
         Console.WriteLine("Qual Equipamento vocé gotaria de agendar?");
            Console.WriteLine("[1] TV [2] TV com VCR [3] Projetor de slides [4]Sistemas de áudio-microfone [5]Caixa amplificada [6]Notebooks");
            
            escolha = Convert.ToInt32(Console.ReadLine());

        switch(escolha)
        {
                
            case 1:
                string? data = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data = Console.ReadLine();
                break;
            case 2:
                string? data2 = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data2 = Console.ReadLine();
                break;
            case 3:
                string? data3 = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data3 = Console.ReadLine();
                break;
            case 4:
                string? data4 = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data4 = Console.ReadLine();
                break;
            case 5:
                string? data5 = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data5 = Console.ReadLine();
                break;
            case 6:
                string? data6 = ""; 
                Console.WriteLine("Qual a data que deseja agendar:");
                data6 = Console.ReadLine();
                break;
            default:
                escolha = -1;
                break;
            }
            
          

        if(escolha <= 0 )
        {
            Console.WriteLine("Equipamento enexistente");
        }
        else if (escolha == 1)
        {
            Console.WriteLine("Equipamento registrado para retirada ");
        }
            else if (escolha == 2)
        {
            Console.WriteLine("Equipamento registrado para retirada ");
        }
            else if (escolha == 3)
        {
            Console.WriteLine("Equipamento registrado para retirada");
        }
            else if (escolha == 4)
        {
            Console.WriteLine("Equipamento registrado para retirada");
        }
            else if (escolha == 5)
        {
            Console.WriteLine("Equipamento registrado para retirada");
        }
            else if (escolha == 6)
        {
            Console.WriteLine("Equipamento registrado para retirada");
        }

    }
    
}


