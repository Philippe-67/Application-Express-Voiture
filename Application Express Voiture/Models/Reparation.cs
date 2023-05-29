using System.ComponentModel.DataAnnotations;

namespace Application_Express_Voiture.Models
{
    public class Reparation

    {
        [Key]
        public int Id { get; set; }
        public string TypeReparation { get; set; }

        public float PrixDeLaReparation { get; set; }

        public Voiture Voiture { get; set; }    
    }
}
