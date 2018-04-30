using System;
using System.Collections.Generic;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class MyApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {
            Coin a = new Coin();
            a.ChartText = "قیمت سکه";
            a.Categories = new List<string>();
            a.Categories.Add("سکه");
            a.YText = "قیمت سکه بهار آزادی";
            a.Series = new List<CoinSeries>();
            
            CoinSeries cs = new CoinSeries();
            cs.Name = "سکه ۱";
            cs.Data = new List<double>();
            cs.Data.Add(1.5);
            cs.Data.Add(5.5);
            cs.Data.Add(2.5);
            a.Series.Add(cs);
            
            CoinSeries cs2 = new CoinSeries();
            cs2.Name = "سکه ۲";
            cs2.Data = new List<double>();
            cs2.Data.Add(4.5);
            cs2.Data.Add(6.5);
            cs2.Data.Add(3.5);
            a.Series.Add(cs2);
            return Ok(a);
        }
    }
}