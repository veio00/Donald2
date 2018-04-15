using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Donald2.Models;
using Swashbuckle.Swagger.Annotations;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web.Http.Description;

namespace Donald2.Controllers
{
    public class ValuesController : ApiController 
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "GetFoi: http://localhost:3182/api/Values/GetFoi", "value2" };
        }

        [SwaggerOperation("Agora")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [HttpGet]
        public string GetFoi(string coleta)
        {
            Uso u = new Uso();
            //string ru = coleta;
            //u = JsonConvert.DeserializeObject<Uso>(coleta);
            //u= (Uso)JsonConvert.DeserializeObject(coleta);
            //string r = JsonConvert.SerializeObject(u.Hd);
            JavaScriptSerializer serializer1 = new JavaScriptSerializer();
            u = serializer1.Deserialize<Uso>(coleta);
            return u.IdUso.ToString() ;

        }


    }
}
