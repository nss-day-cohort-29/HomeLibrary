﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Language { get; set; }
        public int CategoryId { get; set; }

        // NOTE: We use the DisplayFormat attribute to prevent displaying the time
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Published On")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        
        [NotMapped]
        [Display(Name = "Author")]
        public Author Author { get; set; }

        [Required]
        public string UserId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public Category catagory { get; set; }
        public virtual ICollection<Borrow> Borrows { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }

    }
}