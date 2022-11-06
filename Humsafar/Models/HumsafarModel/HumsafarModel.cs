using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Humsafar.Data;

namespace Humsafar.Models
{
    public class HumsafarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }


        public string SaveHumsafar(HumsafarModel model)
        {
            string msg = "";
            HumsafarEntities db = new HumsafarEntities();
            var SaveHum = new tblHum()
            {
                Name = model.Name,
                City = model.City,
            };
               db.tblHums.Add(SaveHum);
               db.SaveChanges();
              return msg;
        }

        public List<HumsafarModel> GetHumsafar()
        {
            HumsafarEntities db = new HumsafarEntities();
            List<HumsafarModel> lsttechnical = new List<HumsafarModel>();
            var AddHum = db.tblHums.ToList();
            if(AddHum!= null)
            {
                foreach(var Technical in AddHum)
                {
                    lsttechnical.Add(new HumsafarModel()
                    {
                        Id = Technical.Id,
                        Name = Technical.Name,
                        City = Technical.City,
                    });
                }
            }
            return lsttechnical;
        }
    }
}