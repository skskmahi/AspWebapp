using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //// GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ActionName("GetEventDetails")]
        public EventMgmt Get(int id)
        {
            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Server=(localdb)\v11.0;Database=MVCAPP;";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from EventTB where EventID=" + id + "";
            sqlCmd.Connection = myConnection;
            myConnection.Open();
            reader = sqlCmd.ExecuteReader();
            EventMgmt ee = null;
            while (reader.Read())
            {
                ee = new EventMgmt();
                ee.EventID = Convert.ToInt32(reader.GetValue(0));
                ee.EventName = Convert.ToString(reader.GetValue(1));
                ee.EventStartDate = Convert.ToDateTime(reader.GetValue(2));
                ee.EventEndDate = Convert.ToDateTime(reader.GetValue(3));
                ee.EventLocation = Convert.ToString(reader.GetValue(4));


            }

            myConnection.Close();
            return ee;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Server=(localdb)\v11.0;Database=MVCAPP;";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update EventTB set EventName="+value+" where EventID=2";
            sqlCmd.Connection = myConnection;
            myConnection.Open();
            reader = sqlCmd.ExecuteReader();
            //EventMgmt ee = null;
            //while (reader.Read())
            //{
            //    ee = new EventMgmt();
            //    ee.EventID = Convert.ToString(reader.GetValue(0));
            //    ee.EventName = Convert.ToString(reader.GetValue(1));
            //    ee.EventStartDate = Convert.ToDateTime(reader.GetValue(2));
            //    ee.EventEndDate = Convert.ToDateTime(reader.GetValue(3));
            //    ee.EventLocation = Convert.ToString(reader.GetValue(4));


            //}

            myConnection.Close();
            //return ee;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
