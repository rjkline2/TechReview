using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechReview.Models
{
    //Category table, this will allow us to create categories for our reviews
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }


    }
}