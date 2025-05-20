namespace LAB4.Models;

public partial class TitlesStatus
{//
    public int Id { get; set; }

    public short IdStatus { get; set; }

    public int IdAnime { get; set; }

    public DateOnly? DateStatuses { get; set; }

    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
