using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReview.Models
{
    public class Review
    {
        //Setting up tables for db and fields to fill out.
        [Key]
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name = "Date Reviewed")]
        public DateTime PublishedDate { get; set; }
        public string Etc { get; set; }
        
        //Fields used from another db table, called Category.
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}