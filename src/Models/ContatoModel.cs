using System.ComponentModel.DataAnnotations;

namespace acfisio.Models
{
    public class ContatoModel
    {
        public string name { get; set; }

        public string email { get; set; }
        
        public string telefone { get; set; }

        public string message { get; set; }
    }
}