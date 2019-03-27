
using System.Web.Mvc;
using FiltersAndAuth.Models;

namespace FiltersAndAuth.Providers
{
    public class MyModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // Получаем поставщик значений
            var valueProvider = bindingContext.ValueProvider;
            
            // получаем данные по одному полю
            ValueProviderResult vprId = valueProvider.GetValue("Id");

            // получаем данные по остальным полям
            string name = (string)valueProvider.GetValue("Name").ConvertTo(typeof(string));
            string author = (string)valueProvider.GetValue("Author").ConvertTo(typeof(string));
            int year = (int)valueProvider.GetValue("Year").ConvertTo(typeof(int));
            var integerVal = (int)vprId.ConvertTo(typeof(int));
            Book book = new Book() { Name = name + " (new)", Author = author };
            var type = valueProvider.GetType();
            // если поле Id определено (редактирование)
            if (vprId != null)
            {
                book.Name = name; // без new
                book.Id = (int)vprId.ConvertTo(typeof(int));
            }
            return book;
        }
    }
}