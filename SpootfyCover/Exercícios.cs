class ContaBancaria
{
    public int NumeroIndicador  {get; set;}
    public string Titular { get; set;}
    public double Saldo {  get; set;}
    public int Senha {  get; set;}
 
    public void ExibirConta()
    {
        Console.Write($"Informe a senha de acesso: ");
        int identificacao = int.Parse(Console.ReadLine()!);
        if (identificacao == Senha)
        {
            Console.WriteLine($"Olá {Titular},");
            Console.WriteLine($"Código da conta: {NumeroIndicador}");
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"Seu saldo atual é de: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Senha incorreta");
        }
    }
}

class Titular
{
    public string Nome { get; set; }
}

class Conta
{
    public Titular Titular { get; set; }
    public string Agencia { get; set; }
    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public decimal Limite { get; set; }

    public string InfoDetalhada()
    {
        return $"Titular: {Titular.Nome}\n" +
               $"Agência: {Agencia}\n" +
               $"Conta: {NumeroConta}\n" +
               $"Saldo: {Saldo}\n" +
               $"Limite: {Limite}";
    }
}

class Carro
{
    public string Acelerar => $"Carro Acelerando...";
    public string Frear => $"Carro Desacelerando...";
    public string Buzinar => $"Bi! Bi!";
    private int _anoDoVeiculo;
    public int AnoDoVeiculo
    {
        get => _anoDoVeiculo;
        set => _anoDoVeiculo = (value >= 1960 && value <= 2023)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(AnoDoVeiculo), "Ano de fabricação inválido, insira o valor entre 1960 á 2023");
    }
    public string ModeloDoVeiculo { get; set; }
    public string Fabricante { get; set; }
    public string DescricaoDetalhada => $"O veículo é fabricado por {Fabricante}, modelo {ModeloDoVeiculo} e o ano de Fabricação é {AnoDoVeículo}";
}

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private decimal _preco;
    public decimal Preco
    {
        get => _preco;
        set => _preco = (value >= 0)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(Preco), "Preço não pode ser negativo");
    }
    private int _estoque;
    public int Estoque
    {
        get => _estoque;
        set => _estoque = (value >= 0)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(Estoque), "Estoque não pode ser negativo");
    }
    public string Descritivo => $"O {Nome} da Marca {Marca} está com o preço atual de R${Preco} e seu estoque é {Estoque}";
}


class ProdutoNovo
{
    public string Nome { get; set; }
    public string Marca { get; set; }
}

class Estoque
{
    private List<ProdutoNovo> produtos = new();

    public void AdicionarProduto(ProdutoNovo produto)
    {
        produtos.Add(produto);
    }

    public void ExibirProdutos()
    {
        Console.WriteLine("Produtos no estoque:");
        foreach (var p in produtos)
        {
            Console.WriteLine($"- {p.Nome} ({p.Marca})");
        }
    }
}


class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new();
}

class Professor
{
    public string Nome { get; set; }
    public List<Disciplina> Disciplinas { get; set; } = new();
}

class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new();
}

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new();
    public List<CardapioItem> Cardapio { get; set; } = new();
}

class Mesa
{
    public int Numero { get; set; }
    public bool Reservada { get; set; }
}

class Pedido
{
    public Mesa Mesa { get; set; }
    public List<CardapioItem> Itens { get; set; } = new();
}

class CardapioItem
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}