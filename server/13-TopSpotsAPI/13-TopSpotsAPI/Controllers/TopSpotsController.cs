using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {

           //GET /api/topspots
        public IEnumerable<TopSpots> Get()
        {


            string fileName = HttpContext.Current.Server.MapPath("../topspots.json");



            string json = File.ReadAllText(fileName);

            IEnumerable<TopSpots> topSpots = JsonConvert.DeserializeObject<IEnumerable<TopSpots>>(json);


                return topSpots;

                //IEnumerable A read Only Array
                //ICollection A collection that we can add to 


           // TopSpots topspots1 = JsonConvert.DeserializeObject<TopSpots>(File.ReadAllText(@"c:\dev\topspots.json"));
            //return new TopSpots[];
            {
               
            }

        }
    }
}
