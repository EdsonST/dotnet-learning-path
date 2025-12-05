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
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

    public string Nome { get;}
    public string Cpf { get; }
    public string Endereco { get; }
}

class Conta
{
    public Conta(Titular titular, int agencia, int numeroConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Limite = limite;
    }

    public Titular Titular { get; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {NumeroConta}, Agência {Agencia}, Titular: {Titular.Nome} - Saldo: {Saldo}";
}

/* intanciando
var titular = new Titular("Edson","123.456.789-00","Rua Teste SBC, 100");
var conta = new Conta(titular,001,1234,2500.0,500.0);
*/

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

class Jogo
{
    public Jogo(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
}

class CatalogoDeJogos
{
    public CatalogoDeJogos()
    {
        Jogos = new List<Jogo>();
    }

    private List<Jogo> Jogos;

    public void AdicionarJogo(Jogo jogo)
    {
        Jogos.Add(jogo);
    }

    public void RemoverJogo(Jogo jogo)
    {
        Jogos.Remove(jogo);
    }

    public void ListarJogos()
    {
        foreach (var jogo in Jogos)
        {
            Console.WriteLine(jogo.Nome);
        }
    }
}