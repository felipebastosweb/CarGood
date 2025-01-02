using SQLite;


namespace FelipeBastosWeb.Data.Models
{
    public class User : BaseModel
    {
        [Unique]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}
