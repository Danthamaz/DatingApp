namespace API.Entities;

public class AppUser
{
    //primary key in database based on convention (since named Id) 
    public int Id { get; set; }
    public required string UserName { get; set; }
}
