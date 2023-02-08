using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPracticeWinter2023.Controllers
{
    public class LoopExerciseController : ApiController
    {
        [HttpGet]
        [Route("api/LoopExercise/Counter/{start}/{limit}/{step}")]
        public string Counter(int start, int limit, int step)
        {
            string output = "";
            string delimiter = ",";
            for(int i = start; i <= limit; i = i + step)
            {
                if(i == limit)
                {
                    delimiter = "";
                }
                output = output + i + delimiter;
            }
            return output;
        }
    }
}
