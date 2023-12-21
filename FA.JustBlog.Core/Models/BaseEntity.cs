using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FA.JustBlog.Core.Models
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            IsDeleted = false;
        }

        public int Id { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        //[Display(Name = "Inserted At")]
        //public DateTime InsertedAt { get; set; }

        //[Display(Name = "Updated At")]
        //public DateTime UpdatedAt { get; set; }
    }
}
