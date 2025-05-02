namespace LAB4.Models;

public partial class Type
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
