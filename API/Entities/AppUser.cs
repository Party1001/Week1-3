namespace API.Entities;
#nullable disable
public class AppUser
{
    //snippet: typing "prop" then press tap
    public int Id { get; set; }
    public string UserName { get; set; }
     public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

}