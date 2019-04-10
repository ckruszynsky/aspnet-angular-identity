namespace AuthServer.Infrastrucutre.Data.Identity
{
    public class AppUser: IdentityUser {
       public string Name { get; set; }

       //add additonal profile data for applications here
    }
}