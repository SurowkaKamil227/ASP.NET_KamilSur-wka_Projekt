using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Birth
    {

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && (BirthDate == null || BirthDate < DateTime.Now);
        }

        [Required(ErrorMessage = "Pole 'Imi�' jest wymagane.")]
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

                // Sprawd�, czy ju� obchodzi�e� urodziny w tym roku
                if (BirthDate.Value.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }

            // W przypadku braku daty urodzenia, mo�esz zwr�ci� jak�� warto�� oznaczaj�c� b��d lub brak wieku
            return -1;
        }
    }


}
