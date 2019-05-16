using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Askerlik.WebApi.Controllers
{
    public class AskerController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<Askerlik.Core.Asker> Get()
        {
            List<Askerlik.Core.Asker> askr;
            using (Askerlik.Core.AskerlikDbEntities db = new Core.AskerlikDbEntities())
            {
                askr = db.Asker.ToList();
            }
            return askr;
        }

        [HttpPost]
        [Authorize] //Authorize attribute token olmayanların erişimini engeller
        [ActionName("AskerAl")]
        public List<string> Post()
        {
            List<string> list = new List<string>() {
                "asdaa",
                "asda"
            };
            return list;
            //return new List<MyData> { new MyData() { Name = "Test1" }, new MyData() { Name = "Test2" }, new MyData() { Name = "Tes3" } };
        }

        [HttpPost]
        [Authorize] //Authorize attribute token olmayanların erişimini engeller
        [ActionName("AskerEkle")]
        public IHttpActionResult Post([FromBody] Askerlik.Core.Asker askr)
        {
            try
            {
                if (askr == null)
                {
                    return BadRequest();
                }

                using (Askerlik.Core.AskerlikDbEntities db = new Askerlik.Core.AskerlikDbEntities())
                {
                    db.Asker.Add(askr);
                    db.SaveChanges();
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
