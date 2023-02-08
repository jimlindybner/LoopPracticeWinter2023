using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPracticeWinter2023.Controllers
{
    public class LoopController : ApiController
    {
        /// <summary>
        /// 1. count from 5 to 20
        /// 2. count from 10 to 13
        /// 3. count from 20 to 0
        /// 4. count from 0 to 10 by 2s
        /// </summary>
        /// <returns>1 2 3 4 5 6 7 8 9 10</returns>

        [HttpGet]
        [Route("api/Loop/ForLoopTest")]
        public string ForLoopTest()
        {
            string message = "";
            for (int i = 0; i <= 10; i+=2)
            {
                message = message + i + ",";
            }
            return message;
        }

        [HttpGet]
        [Route("api/Loop/WhileLoopTest/{ceiling}")]

        public string WhileLoopTest(int ceiling)
        {
            string message = "";
            int i = 0;
            string delimiter = " ";
            while (i <= ceiling)
            {
                if(i == ceiling)
                {
                    delimiter = "";
                }
                message = message + i + delimiter;
                i++;
            }
            return message;
        }

        [HttpGet]
        [Route("api/Loop/ForEachLoopTest")]
        public string ForEachLoopTest()
        {
            string output = "";

            List<string> shows = new List<string>()
            {
                "Peaky Blinders", "Breaking Bad", "House of Cards"
            };
            foreach(string show in shows)
            {
                output = output + show + " | ";
            }
            return output;
        }
    }
}
