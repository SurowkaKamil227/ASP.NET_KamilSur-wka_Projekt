using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Birth
    {

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && (BirthDate == null || BirthDate < DateTime.Now);
        }

        [Required(ErrorMessage = "Pole 'Imiê' jest wymagane.")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Pole 'Data urodzenia' jest wymagane.")]
        public DateTime? BirthDate { get; set; }

        public int ObliczWiek()
        {
            if (BirthDate.HasValue)
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Value.Year;

                // SprawdŸ, czy ju¿ obchodzi³eœ urodziny w tym roku
                if (BirthDate.Value.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }

            // W przypadku braku daty urodzenia, mo¿esz zwróciæ jak¹œ wartoœæ oznaczaj¹c¹ b³¹d lub brak wieku
            return -1;
        }
    }


}
