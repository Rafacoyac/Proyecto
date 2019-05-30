using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Data
{
    public class BinnacleData
    {
        public  Boolean Crear()
        {
            ApptecEntities data = new ApptecEntities();
            Boolean existe = false;
            var d = new Binnacle
            {
                Actions = "crear nuevo registro",
                Users = 1,
                Error = "nothing",
                Messages = "fine",
                DateTime = DateTime.Now
            };
            data.Binnacles.Add(d);
            data.SaveChanges();

            if (d != null)
                existe = true;

            return existe;
        }
    }
}