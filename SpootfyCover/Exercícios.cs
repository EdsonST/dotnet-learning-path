class ContaBancaria
{
    public int numeroIndicador { get; set; }
    public string titular {  get; set; }
    public double saldo { get; set; }
    public int senha { get; set; }

    public void ExibirConta()
    {
        Console.Write($"Informe a senha de acesso: ");
        int identificacao = int.Parse(Console.ReadLine()!);
        if (identificacao == senha)
        {
            Console.WriteLine($"Olá {titular},");
            Console.WriteLine($"Código da conta: {numeroIndicador}");
            Console.WriteLine($"Titular da conta: {titular}");
            Console.WriteLine($"Seu saldo atual é de: {saldo}");
        }
        else
        {
            Console.WriteLine($"Senha incorreta");
        }

    }
}

class Carro
{
    public void acelerar()
    {
        Console.WriteLine("Carro Acelerando...");
    }
    public void frear() 
    {
        Console.WriteLine("Carro Desacelerando...");
    }
    public void buzinar() 
    { 
        Console.WriteLine("Bi ! Bi !");
    }
}