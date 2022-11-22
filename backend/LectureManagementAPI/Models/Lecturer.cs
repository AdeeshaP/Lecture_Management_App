using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LecturersWebApi.Models
{
    public class Lecturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(150)]
        public string Email { get; set; }
        public DateTime DateofJoined { get; set; }

        [StringLength(150)]
        public string Qualification { get; set; }

        public int DesignationID { get; set; }

        [NotMapped]
        public string ModuleName { get; set; }


    }
}
