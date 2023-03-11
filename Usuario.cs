using System;

public class Usuario
{
    public string? nome, email;
    public int id;
        
    public void registra()
    {
        Console.Write("Qual seu nome: ");
        Console.ReadLine();
        Console.Write("Qual seu Email: ");
        Console.ReadLine();
        Console.Write("Qual seu ID: ");
        Console.ReadLine();
    }
}
