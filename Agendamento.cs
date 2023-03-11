using System;
using System.Collections.Generic;

public class Agendamento
{
    public int escolha;
     Dictionary<DateTime, string> agenda = new Dictionary<DateTime, string>();

    public void dataAgenda()
    {
       while (true)
            {
            Console.WriteLine("Digite a data (dd/mm/aaaa) ou digite 'sair' para encerrar:");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            if (DateTime.TryParse(input, out DateTime data))
            {
                if (agenda.ContainsKey(data))
                {
                    Console.WriteLine("Data já agendada!");
                }
                else
                {
                    Console.WriteLine("Digite o evento:");
                    string evento = Console.ReadLine();
                    agenda.Add(data, evento);
                    Console.WriteLine("Evento agendado!");
                }
            }
            else
            {
                Console.WriteLine("Data inválida!");
            }
        }

        Console.WriteLine("\nAgenda:");

        foreach (KeyValuePair<DateTime, string> item in agenda)
        {
            Console.WriteLine("{0}: {1}", item.Key.ToShortDateString(), item.Value);
        }
        }
}
