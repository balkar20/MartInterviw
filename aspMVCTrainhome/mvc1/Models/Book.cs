using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Web.Mvc;

namespace mvc1.Models
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        
        [Display(Name = "Год")]
        public int Year { get; set; }
    }
}