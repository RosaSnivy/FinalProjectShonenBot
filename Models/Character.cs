using System.ComponentModel.DataAnnotations;

namespace final.Models;

public class Character
{
    public int CharacterID {get; set;} // Primary Key
    public string CharacterName {get; set;} = string.Empty;
    public int HP {get; set;}
    public int Strength {get; set;}
    public int Durability {get; set;}
    public string CharImageURL {get; set;} = string.Empty;
    public Anime Anime {get; set;} = default!; // Nav
    
}