using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_project_API.DAL.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
