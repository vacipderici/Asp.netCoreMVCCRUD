using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Emp Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

    }
}
