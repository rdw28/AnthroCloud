﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnthStat.Statistics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnthroCloud.Business;

namespace AnthroCloud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        // GET: api/Stats/WeightForAge/9.00/365/Male
        [HttpGet("{indicator}/{measurement}/{ageInDays}/{sex}")]
        [Route("STATS/{indicator}/{measurement}/{ageInDays}/{sex}")]
        public Tuple<double, double> GetScores(Indicator indicator, double measurement, double ageInDays, Sex sex)
        {
            Stats stats = new Stats();
            Tuple<double, double> scores = stats.getScores(indicator, measurement, ageInDays, sex);
            return scores;
        }

        //// GET: api/Stats
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Stats/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Stats
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stats/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}