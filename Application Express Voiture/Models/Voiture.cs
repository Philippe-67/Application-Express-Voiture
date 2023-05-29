using System.ComponentModel.DataAnnotations;

namespace Application_Express_Voiture.Models
{
    public class Voiture

    {
        [Key]
        public int Id { get; set; }
        public string Marque{ get; set; }
        public  string Modele { get; set; }
        public float PrixAchat { get; set; }


        public ICollection<Reparation> Reparation { get; set; }
    }
}
