﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc;
using CoronaApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<Location> Get([FromQuery] LocationSearch locationSearch=null)
        {
            ILocationRepository locationRepo = new LocationRepository();
            return locationRepo.Get(locationSearch);
        }

     

      
    }
}