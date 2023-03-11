using System;


namespace _pim
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("******Bem-Vindo******");
            Console.WriteLine("Colégio Vencer Sempre");
            Console.WriteLine("----------------------");

           //class
            Usuario pessoa = new Usuario();
            Pessoa usuario = new Pessoa();
            Agendamento dat = new Agendamento();
            
            usuario.colaborador();
            usuario.registra();
            
            Console.WriteLine("----------------------");

            dat.dataAgenda();
        
        }
    }
}
