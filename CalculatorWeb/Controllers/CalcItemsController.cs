using CalculatorAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CalculatorWeb.Controllers
{
    public class CalcItemsController : ApiController
    {
        SimpleCalculator c = new SimpleCalculator();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id.ToString();
        }

        [HttpPost]
        public int Add(int a, int b)
        {
            return c.Add(a,b);
        }

        [HttpPost]
        public int Subtract(int a, int b)
        {
            return c.Subtract(a,b);
        }

        [HttpPost]
        public int Multiply(int a, int b)
        {
            return c.Multiply(a, b);
        }

        [HttpPost]
        public int Divide(int a, int b)
        {
            return c.Divide(a, b);
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            string mess = value + "  " + " RETURN VAL";
            return mess;
        }
    }
}