using Microsoft.AspNetCore.Identity;

namespace Ex11e12_CrudComAutenticacao_AT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
    }
}
