using System.ComponentModel.DataAnnotations;

namespace MovieBookingSytem.Core.Domain
{

    //Cinema class prototype
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [MaxLength(300)]
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }

        [MaxLength(10)]
        [Required(AllowEmptyStrings = false)]

        public  string Contact { get; set; }
        public int NoOfSeats { get; set; }     

    }

 
}
