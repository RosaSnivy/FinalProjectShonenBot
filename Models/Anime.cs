using System.ComponentModel.DataAnnotations;

namespace final.Models;

public class Anime 
{
    public int AnimeID {get; set;} // Primary key
    public string AnimeName {get; set;} = string.Empty;
    public string ImageURL {get; set;} = string.Empty;
    public List<Character> Characters {get; set;} = default!; //Nav
}