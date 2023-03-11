using System;

public class Pessoa:Usuario
{
    public int professor;


    public void colaborador()
    {   
    Console.WriteLine("Gostaria de agendar para quem?");
    Console.WriteLine("[1]Professor [2] Coodernador");
    
    professor = Convert.ToInt32(Console.ReadLine());

    switch (professor)
    {
        case 1:
            Console.WriteLine("Agendamento para Professor");
            break;
        case 2:
            Console.WriteLine("Agendamento para Coodernador ");
            break;
        default:
            professor = -1;
            break;
    }

    
        if(professor <=0)
        {
            Console.WriteLine("Usuario inexistente");
        }
        else
        {
            Console.WriteLine("---------------------");
        }
    }
}