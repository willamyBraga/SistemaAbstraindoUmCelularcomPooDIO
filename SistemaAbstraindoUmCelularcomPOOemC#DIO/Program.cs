using System;

// Classe abstrata que representa a estrutura básica de um celular
public abstract class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void Ligar();
    public abstract void EnviarMensagem(string mensagem);
    public abstract void FazerChamada(string numero);
}

// Classe concreta que herda de Celular e implementa o comportamento específico para uma marca/modelo
public class SamsungGalaxy : Celular
{
    public override void Ligar()
    {
        Console.WriteLine($"Ligando o {Marca} {Modelo}");
    }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem do {Marca} {Modelo}: {mensagem}");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Fazendo chamada do {Marca} {Modelo} para o número: {numero}");
    }
}

// Classe concreta que herda de Celular e implementa o comportamento específico para outra marca/modelo
public class IPhone : Celular
{
    public override void Ligar()
    {
        Console.WriteLine($"Ligando o {Marca} {Modelo}");
    }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem do {Marca} {Modelo}: {mensagem}");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Fazendo chamada do {Marca} {Modelo} para o número: {numero}");
    }
}

class Program
{
    static void Main()
    {
        Celular celularSamsung = new SamsungGalaxy { Marca = "Samsung", Modelo = "Galaxy S21" };
        Celular celularIPhone = new IPhone { Marca = "Apple", Modelo = "iPhone 13" };

        celularSamsung.Ligar();
        celularSamsung.EnviarMensagem("Olá, como está?");
        celularSamsung.FazerChamada("123456789");

        celularIPhone.Ligar();
        celularIPhone.EnviarMensagem("Oi, tudo bem?");
        celularIPhone.FazerChamada("987654321");
    }
}
