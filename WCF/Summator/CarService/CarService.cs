using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace CarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class CarService : ICarService
    {
        public void SrtCar(Car c)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];

            var doc = XDocument.Load(file);

            doc.Root.Add(new XElement("Car", new XAttribute("Id", c.Id), new XElement("Vendor", c.Vendor),
                                        new XElement("Model", c.Model), new XElement("Year", c.Year)));

            doc.Save(file);
        }

        public Car GetCar(int id)
        {
            var file = ConfigurationManager.AppSettings["fileCar"];
            var result = new Car();
            var doc = XDocument.Load(file);

            var element = doc.Descendants("Car").FirstOrDefault(x => x.Attribute("Id").Value == id.ToString());

            result.Id = int.Parse(element.Attribute("Id").Value);
            result.Vendor = element.Element("Vendor").Value;
            result.Model = element.Element("Model").Value;
            result.Year = int.Parse(element.Element("Year").Value);

            return result;
        }
    }
}
