using System.ComponentModel.DataAnnotations;

namespace final.Models;

public class Anime 
{
    public int AnimeID {get; set;} // Primary key
    [StringLength(30, MinimumLength = 3)]
    public string AnimeName {get; set;} = string.Empty;
    public string AnimeImageURL {get; set;} = string.Empty;
    public List<Character> Characters {get; set;} = default!; //Nav
}