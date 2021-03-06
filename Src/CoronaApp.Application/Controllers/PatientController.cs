﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoronaApp.Services;
using CoronaApp.Services.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public object Get(string id)
        {
            return _patientService.Get(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody]Patient patient)
        {
            _patientService.Save(patient);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        //[HttpGet("{id}")]
        //public void func1(string id)
        //{
        //    PatientModel p = new PatientModel(id);
        //    PatientRepository patientRepo = new PatientRepository();
        //    patientRepo.func(p);
        //}

    }
}
