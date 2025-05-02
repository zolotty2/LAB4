namespace LAB4.Models;

public partial class TitlesGenre {
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public int IdAnime { get; set; }

    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

}
