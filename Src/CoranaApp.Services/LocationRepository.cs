﻿using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaApp.Services
{
   public class LocationRepository : ILocationRepository
    {
       public static List<LocationModel> locations= new List<LocationModel>()
            {
                new LocationModel("Jerusalem",new DateTime(2005, 12, 12),new DateTime(2005, 11, 12),"school","111"),
                new LocationModel("Bney Brak",new DateTime(2004, 12, 12),new DateTime(2004, 11, 12),"park","111"),
                new LocationModel("Bney Brak",new DateTime(2004, 12, 12),new DateTime(2004, 11, 12),"library","111"),
                new LocationModel("Jerusalem",new DateTime(2005, 12, 12),new DateTime(2005, 11, 12),"restaurant","222"),
            };
        
        public ICollection<LocationModel> Get(LocationSearchModel locationSearch=null)
        {
            try
            {
                var list = locations;
                if (locationSearch.city != null && locationSearch.city != "All" && locationSearch.city != "")
                {
                    list = list.Where(c => c.city == locationSearch.city).ToList();
                    return list;
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
               // return this.StatusCode(StatusCodes.Status500InternalServerError, "data failed");
            }
        }
    }
}
