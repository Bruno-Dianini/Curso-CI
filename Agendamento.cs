using System;
using System.Collections.Generic;

public class Agendamento
{
    public string? sair;
     Dictionary<DateTime, string?> agenda = new Dictionary<DateTime, string?>();

    public void dataAgenda()
    {
       while (true)
            {
            Console.WriteLine("Digite a data (dd/mm/aaaa) ou digite 'sair' para encerrar:");
            sair = Console.ReadLine();

            if (sair == "sair")
                break;

            if (DateTime.TryParse(sair, out DateTime data))
            {
                if (agenda.ContainsKey(data))
                {
                    Console.WriteLine("Data já agendada!");
                }
                else
                {
                    Console.WriteLine("Digite qual equipamento gostaria de solicitar:");
                    string? reserva = Console.ReadLine();
                    agenda.Add(data, reserva);
                    Console.WriteLine("Equipamento reservado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine("Data inválida!");
            }
        }

        Console.WriteLine("\nAgenda:");

        foreach (KeyValuePair<DateTime, string?> item in agenda)
        {
            Console.WriteLine("{0}: {1}", item.Key.ToShortDateString(), item.Value);
        }
        }
}
