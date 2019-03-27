using System.Web.Mvc;
using FiltersAndAuth.Providers;

namespace FiltersAndAuth.Models
{

    [ModelBinder(typeof(MyModelBinder))]
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        //public string Year { get; set; }
    }

}