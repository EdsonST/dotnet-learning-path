class Musicas
{
    public int IdBanda { get; set; }
    public string NomeBanda { get; set; }
    public string NomeArtista { get; set; }
    public string Estilo {  get; set; }
    public int Ducacao { get; set; }
    public bool Disponibilidade { get ; set ; }
    public string FichaTecnica => $"A {NomeBanda} é interpretada pelo {NomeArtista} no estilo {Estilo}";

    public void ExibirCadastro()
    {
        Console.WriteLine($"ID: {IdBanda}");
        Console.WriteLine($"Banda: {NomeBanda}");
        Console.WriteLine($"Artista: {NomeArtista}");
        Console.WriteLine($"Estilo Musical: {Estilo}");
        Console.WriteLine($"Duração da Música: {Ducacao}min");

        if (Disponibilidade)
        {
            Console.WriteLine($"Disponível em seu plano !");
        }
        else
        {
            Console.WriteLine($"Não está disponível em seu plano !");
        }

    }
}

