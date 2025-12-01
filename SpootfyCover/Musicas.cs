class Musicas
{
    public int idBanda { get; set; }
    public string nomeBanda { get; set; }
    public string nomeArtista { get; set; }
    public string estilo {  get; set; }
    public int ducacao { get; set; }
    public bool disponibilidade { get; set; }

    public void ExibirCadastro()
    {
        Console.WriteLine($"ID: {idBanda}");
        Console.WriteLine($"Banda: {nomeBanda}");
        Console.WriteLine($"Artista: {nomeArtista}");
        Console.WriteLine($"Estilo Musical: {estilo}");
        Console.WriteLine($"Duração da Música: {ducacao}min");

        if (disponibilidade)
        {
            Console.WriteLine($"Disponível em seu plano !");
        }
        else
        {
            Console.WriteLine($"Não está disponível em seu plano !");
        }

    }
}

