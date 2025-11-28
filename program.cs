using System.IO.Pipes;
using System.Net.Security;
using System.Text.RegularExpressions;

class Course01
{
    public void CalculateAge(int YearOfBirth)
    {
        int TodayYear = DateTime.Now.Year;
        int CurrentYear = TodayYear - YearOfBirth;

        if (CurrentYear >= 18)
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is of legal age");
        }
        else
        {
            Console.WriteLine($"The User has {CurrentYear} years old, is a minor");
        }
    }

    public void Donations(decimal ValueDonation, bool Anonimous, char Account)
    {
        if (Account != 'P' && Account != 'C')
        {
            Console.WriteLine("Invalid account type");
            return;
        }

        if (ValueDonation <= 0)
        {
            Console.WriteLine("The donation cannot be completed, value incompatible!");
        }
        else
        {
            Console.WriteLine($"Amount received: ${ValueDonation}");
            Console.WriteLine($"Anonymous donation: {Anonimous}");
            Console.WriteLine($"Account type: {Account}");
        }
    }

    public void ConversionMiles(double Miles)
    {
        double Kilometrers = 1.60934;
        double Consersor = Miles * Kilometrers;

        Console.WriteLine($"{Miles} Miles are equivalent to {Consersor} kilometrers");
    }

    public void ConversionTime(int MinutesToHours)
    {
        int Hours = MinutesToHours / 60;
        int Minutes = MinutesToHours % 60;

        Console.WriteLine($"Time is {Hours} hours and {Minutes} minutes");
    }

    public void AreaConverter(double Width, double Length)
    {
        double Area = Width * Length;

        Console.WriteLine($"The area of the land is {Area:F2} square meters.");
    }

    public void AverageNote(double Note1, double Note2, double Note3)
    {
        List<double> Notes = new List<double>();
        Notes.Add(Note1);
        Notes.Add(Note2);
        Notes.Add(Note3);
        double StudentAverage = Notes.Average();

        Console.WriteLine($"The average grade is: {StudentAverage:F1}");
    }

    public void TruckForCargo(decimal Cargo)
    {
        int vehicles = (int)Cargo;

        Console.WriteLine($"Vehicles necessary: {vehicles}");
    }     

    public void LivesControl(int initial)
    {
        int changes = 3;
        string password = "OK";

        Console.WriteLine($"Welcome you has {changes} changes");

        do
        {
            string userChoose = Console.ReadLine();

            if (userChoose == password)
            {
                Console.WriteLine("Great");
                initial++;
                changes--;
                Console.WriteLine($"You has {changes} changes");
            } else
            {
                Console.WriteLine("Oh no!");
                initial--;
                changes--;
                Console.WriteLine($"You has {changes} changes");
            }
            
        }
        while (changes > 0);

        Console.WriteLine($"Final Live: {initial}");
    }

    public void SalaryIncrease(decimal salary, decimal percentage)
    {
        decimal newSalary = ( salary + (salary * (percentage / 100)));

        Console.WriteLine($"New salary is: ${newSalary:F2}");
    }

    public void CircunferenceCalc(double radius)
    {
        decimal PI = 3.14159M;
        decimal circleArea = PI * (decimal)radius * (decimal)radius;
        decimal circlePerimeter = 2 * PI * (decimal)radius;

        Console.WriteLine($"Radius: {radius:F2}");
        Console.WriteLine($"Circle Area: {circleArea:F2}");
        Console.WriteLine($"Circle Perimeter: {circlePerimeter:F2}");
    }
}

class Course02
{
    public void BalanceAnalysis(decimal balance)
    {
        if (balance > 0.0m) 
        {
            Console.WriteLine($"Your ballance is positive !");
        } else if (balance == 0.0m)
        {
            Console.WriteLine($"Your ballance is zero");
        } else
        {
            Console.WriteLine($"Your ballance is negative !");
        }
    }

    public void ProductClassification()
    {
        Console.Write("Enther the product code (1 or 2): ");
        int code = int.Parse(Console.ReadLine());

        if (code == 1)
        {
            Console.WriteLine("Product Perishable");
        } else if (code == 2)
        {
            Console.WriteLine("Product Non-perishable");
        } else
        {
            Console.WriteLine("Invalid Code");
        }
    }

    public void StuentAvaliation()
    {
        Console.WriteLine("Please provide the student's final grade:");
        double note = double.Parse(Console.ReadLine());

        switch (note)
        {
            case >= 9: Console.WriteLine("A");
                break;
            case >= 7: Console.WriteLine("B");
                break;
            case >= 5: Console.WriteLine("C");
                break;
            default: Console.WriteLine("D");
                break;
        }
    }

    public void CredentialValidation()
    {
        Console.WriteLine("Enter your password: ");
        int password = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your access level: ");
        int level = int.Parse(Console.ReadLine());

        int corretpass = 42;

        if (password == corretpass && level >= 5)
        {
            Console.WriteLine("Access released");
        } else
        {
            Console.WriteLine("Access denied");
        }

    }

    public void EtharialClassification()
    {
        Console.WriteLine("Enter the age:");
        int age = int.Parse(Console.ReadLine());

        switch (age)
        {
            case >= 60: Console.WriteLine("Classification: Elderly");
                break;
            case >= 18: Console.WriteLine("Classification: Adult");
                break;
            case >= 13: Console.WriteLine("Classification: Teenager");
                break;
            default: Console.WriteLine("Classification: Children");
                break;
        }
    }

    public void Calculator()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operator (+, -, *, /):");
        string operatorMode = Console.ReadLine();

        switch (operatorMode)
        {
            case "+": Console.WriteLine($"Result: {firstNumber + secondNumber}");
                break;
            case "-": Console.WriteLine($"Result: {firstNumber - secondNumber}");
                break;
            case "*": Console.WriteLine($"Result: {firstNumber * secondNumber}");
                break;
            case "/": Console.WriteLine($"Result: {firstNumber / secondNumber}");
                break;
            default:Console.WriteLine("Operator not found");
                break;
        }
    }

    public void Greetings()
    {
        Console.WriteLine("1 - Morning\r\n2 - Afternoon\r\n3 - Evening\n\nWhat time of day is it now?");
        int chooseTime = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();

        switch (chooseTime)
        {
            case 1: Console.WriteLine($"Good Morning, {name}.");
                break;
            case 2: Console.WriteLine($"Good Afternoon, {name}.");
                break;
            case 3: Console.WriteLine($"Good Evening, {name}.");
                break;
            default: Console.WriteLine("Option Invalid");
                break;
        }

    }

    public void CodeRewards()
    {
        Console.WriteLine("Enter the reward code (DOUBLE, HEAL, GOLD, SPECIAL)");
        string rewardCode = Console.ReadLine();

        string earned;

        earned = rewardCode switch
        {
            "DOUBLE" => "Earn 2x EXP for 1 hour unlocked !",
            "HEAL" => "Healing potion unlocked !",
            "GOLD" => "1000 gold coins unlocked !",
            "SPECIAL" => "Legendary item unlocked !",
            _ => "Reward unavailable"
        };

        Console.WriteLine(earned);
    }

    public void BookClassification()
    {
       Console.WriteLine("Enter the book code:");
       string codeBook = Console.ReadLine();

       char typeShelf = char.ToUpper(codeBook[0]);

       switch (typeShelf)
        {
            case '1': Console.WriteLine("Science Fiction");
                break;
            case '2': Console.WriteLine("Classical Literature");
                break;
            case '3': Console.WriteLine("Fantasy");
                break;
            case '4': Console.WriteLine("Romance");
                break;
            case '5': Console.WriteLine("Suspense/Mystery");
                break;
            case '6': Console.WriteLine("Non-Fiction");
                break;
            case '7': Console.WriteLine("Biography/Memoirs");
                break;
            case '8': Console.WriteLine("Distopia");
                break;
            case '9': Console.WriteLine("Children and Youth");
                break;
            default: Console.WriteLine("Invalid code"); 
                break;
        }
    }

    public void AutenticationAcess()
    {
        Console.WriteLine("Sistema de Autenticação\r\n-----------------------");
        Console.Write("Digite seu nome de usuário: ");
        string userName = Console.ReadLine();

        string admin = "Edson";

        if (userName == admin)
        {
            Console.WriteLine($"Bem vindo, {userName}.");
        }
        else
        {
            Console.WriteLine($"\nUsuário não cadastrado.\n");
            Console.WriteLine("Opções disponíveis:\r\n[1] Cadastrar novo usuário\r\n[2] Acessar como convidado\r\n[3] Sair");
            int newAccess = int.Parse(Console.ReadLine());

            string newUser;

            switch (newAccess)
            {
                case 1:
                    Console.WriteLine("Informe o nome do novo usuário:");
                    newUser = Console.ReadLine();
                    Console.WriteLine($"Novo usuário {newUser} cadastrado com sucesso!");
                    break;
                case 2: Console.WriteLine("Acesso concedido como convidado.");
                    break;
                default: break;
            }
        }  

    }
}

class Course03
{
    public void Donations()
    {
        double[] valuesOfDonations = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
        double totalDonations = 0;
        foreach (double value in valuesOfDonations)
        {
            totalDonations += value;
        }
        Console.WriteLine($"Total donations: {totalDonations}");
    }

    public void EventParticipants()
    {
        string[] names = new string[] { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };
        Array.Sort(names);

        Console.WriteLine($"The third name in the list is: {names[2]}");
    }

    public void SecretPassword()
    {
        int[] numbers = new int[] { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
        int position1 = numbers[8];
        int position2 = numbers[1];
        int position3 = numbers[13];
        Console.WriteLine($"Padlock combination: {position1}-{position2}-{position3}");
    }

    public void GameScore()
    {
        HashSet<int> scores = new HashSet<int>();
        scores.Add(150);
        scores.Add(90);
        scores.Add(200);
        scores.Add(120);
        scores.Add(150);
        scores.Add(80);
        scores.Add(180);
        scores.Add(200);

        List<int> orderScore = scores.OrderBy(orderScore => orderScore).ToList();

        Console.WriteLine("Unique scores in ascending order:");
        foreach (int score in orderScore) { Console.WriteLine(score); }
    }

    public void SecretMessage()
    {
        List<char> codeSecret = new List<char> { 'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o' };

        codeSecret.Reverse();

        foreach (char code in codeSecret) { Console.WriteLine(code); };
    }

    public void SorteioBeneficiente()
    {
        List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };
        Console.WriteLine($"Lista original:\n{string.Join(",", nomes)}\n");

        nomes.Sort();
        Console.WriteLine($"Após Sort (ordem alfabética):\n{string.Join(",", nomes)}\n");

        nomes.Reverse();
        Console.WriteLine($"Após Reverse (ordem invertida):\n{string.Join(",", nomes)}\n");
        
        string nomeSalvo = nomes[0];
        nomes.Remove(nomes[0]);
        nomes.Add(nomeSalvo);
        Console.WriteLine($"Após remover o primeiro e adicioná-lo no fim:\n{string.Join(",", nomes)}\n");

        Console.WriteLine($"Pessoa sorteada foi: {nomes[3]}");
    }

    public void ListaDeProdutos()
    {
        List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick"};
        List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };

        produtosPrincipal.AddRange(produtosSecundaria);
        //for (int i = 0; produtosSecundaria.Count > i; i++) { produtosPrincipal.Add(produtosSecundaria[i]); };

        Console.WriteLine("Lista consolidada:");
        foreach (string produto in produtosPrincipal) { Console.WriteLine(produto); }
    }

    public void NotasFinais()
    {
        Dictionary<string, decimal> NotasAlunos = new Dictionary<string, decimal>();
        NotasAlunos.Add("Ana", 8.75m);
        NotasAlunos.Add("Bruno", 6.90m);
        NotasAlunos.Add("Clara", 9.25m);

        foreach (var notas in NotasAlunos)
        {
            Console.WriteLine($"Aluno: {notas.Key} - Nota: {notas.Value}");
        }
    }

    public void Inventario()
    {
        Dictionary<int, string> Mochila = new Dictionary<int, string>
        {
            {1,"Espada Longa" },
            {2,"Arco Curto" },
            {3,"Escudo de Ferro" }
        };

        Console.WriteLine("Itens no inventário inicial:");
        foreach (var itens in Mochila)
        {
            Console.WriteLine($"ID: {itens.Key} - {itens.Value}");
        }

        Mochila.Remove(2);
        Mochila.Add(4, "Poção de Vida");
        Console.WriteLine("----------------------------");

        Console.WriteLine("Itens no inventário atualizado:");
        foreach (var itens in Mochila)
        {
            Console.WriteLine($"ID: {itens.Key} - {itens.Value}");
        }
    }

    public void TarefasDaSprint()
    {
        Dictionary<string, string> tarefas = new Dictionary<string, string>
        {
            {"Refatorar módulo de login", "Ana" },
            {"Testar API de pagamentos", "Pedro" }
        };

        tarefas.Clear();

        tarefas.Add("Implementar autenticação OAuth", "João");
        tarefas.Add("Otimizar consultas SQL", "Maria");
        tarefas.Add("Atualizar documentação", "Carlos");

        Console.WriteLine("Tarefas do próximo sprint:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
        }
    }
}

class Course04
{
    public void PalavraChave()
    {
        string palavraChave = "C#";
        Console.WriteLine("Digite um texto:");
        string textoInformado = Console.ReadLine()!;

        if (textoInformado.Contains(palavraChave))
        {
            Console.WriteLine("A palavra - chave foi encontrada na pesquisa.");
        }
        else
        {
            Console.WriteLine("A palavra - chave não foi encontrada na pesquisa.");
        }
    }

    public void ContadorDeCaracteres()
    {
        Console.Write("Digite uma frase: ");
        string textoInformado = Console.ReadLine()!;

        int caracteres = textoInformado.Length;

        Console.WriteLine($"A frase contém {caracteres} caracteres.");
    }

    public void SubstituirPalavra()
    {
        Console.WriteLine("Digite uma frase:");
        string textoInformado = Console.ReadLine()!;

        Console.WriteLine("Qual palavra você quer substituir?");
        string palavraEscolhida = Console.ReadLine()!;

        Console.WriteLine("Por qual palavra?");
        string novaPalavra = Console.ReadLine()!;

        string novoTexto = textoInformado.Replace(palavraEscolhida, novaPalavra);
        Console.WriteLine(novoTexto);
    }

    public void DivisaoDeTexto()
    {
        string textoLog = "2025-03-25,Erro,Arquivo não encontrado";

        string data = textoLog.Split(',')[0];
        string tipo = textoLog.Split(',')[1];
        string mensagem = textoLog.Split(',')[2];

        Console.WriteLine($"Data: {data}");
        Console.WriteLine($"Tipo de erro: {tipo}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }

    public void TransformandoEmMaiusculas()
    {
        Console.WriteLine("Digite o alerta:");
        string texto = Console.ReadLine()!;

        Console.WriteLine(texto.ToUpper());
    }

    public void RelatoriosDeEntregas()
    {
        Console.WriteLine("Digite o nome do cliente:");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite o endereço:");
        string endereco = Console.ReadLine()!;

        Console.WriteLine("Digite o valor do frete:");
        decimal frete = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a data de entrega:");
        string data = Console.ReadLine()!;

        string formato = $@"
        Cliente:           {nome}
        Endereço:          {endereco}
        Valor do frete: R$ {frete}
        Data:              {data}";

        Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========");
        Console.WriteLine(formato);
        Console.WriteLine("==========================================");

    }

    /*/Regex

    string padraoCPF = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
    string padraoCNPJ = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
    string padraoTelefone = @"^\(\d{2}\)\d{4,5}-\d{4}$";
    string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    */

    public void ValidadorDeCupons()
    {
        Console.WriteLine("Digite o código do cupom:");
        string cupom = Console.ReadLine()!;

        string validador = @"^[0-9]+$";


        if (Regex.IsMatch(cupom, validador))
        {
            Console.WriteLine("O código é válido");
        }
        else 
        { 
            Console.WriteLine("O código não é válido."); 
        }
    }

    public void ExtracaoDeTexto()
    {
        Console.WriteLine("Digite o texto do recibo:");
        string notaFiscal = Console.ReadLine()!;

        string validador = @"R\$\s*([0-9]+,[0-9]{2})";

        string valorExtraido = Regex.Match(notaFiscal, validador).Groups[1].Value;

        Console.WriteLine($"Valor encontrado: R$ {valorExtraido}");
    }

    public void ExtracaoDeEspaco()
    {
        Console.WriteLine("Digite sua frase:");
        string frase = Console.ReadLine()!;
        string validador = @"\s+";

        string fraseAjustada = Regex.Replace(frase, validador, " ").Trim();
        Console.WriteLine($"Texto limpo: {fraseAjustada}");
    }

    public void ValidacaoDeData()
    {
        Console.WriteLine("Digite a data (dd/mm/aaaa):");
        string data = Console.ReadLine()!;
        string validador = @"^([0-9]{2})/([0-9]{2})/([0-9]{4})$";

        int dia = int.Parse(Regex.Match(data, validador).Groups[1].Value);
        int mes = int.Parse(Regex.Match(data, validador).Groups[2].Value);
        int ano = int.Parse(Regex.Match(data, validador).Groups[3].Value);

        int anoAtual = DateTimeOffset.Now.Year;

        if (dia >= 1 && dia <= 31)
        {
            if ( mes >= 1 &&  mes <= 12)
            {
                if( ano >= 1800 && ano <= anoAtual)
                {
                    Console.WriteLine("A data está no formato correto.");
                } else
                {
                    Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
                }
            } else
            {
                Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
            }
        } else
        {
            Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
        }
    }

    public void ValidacaoDeLinks()
    {
        Console.WriteLine("Digite o texto:");
        string links = Console.ReadLine()!;
        string validador = @"https?://[^\s]+";

        string linkValidado = Regex.Replace(links, validador, "[LINK]");

        Console.WriteLine(linkValidado);
    }
}

class Course05
{

}