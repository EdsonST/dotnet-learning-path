class Album
{
    private List<Musicas> musicas = new List<Musicas>();

    public string NomeDaBanda { get; set; }
    public int IdBanda { get; set; }

    public void AdicionarMusica(Musicas musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Músicas da {NomeDaBanda}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica}");
        }
    }
}