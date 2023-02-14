using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPracticeWinter2023.Controllers
{
    /**
     * Problem 1: CounterDifficulty:
     * ***GET api/LoopPractice/Counter/{start}/{limit}/{step}outputs:
     * A List of Integers {start} to {limit} counting by {step}eg. 
     * api/LoopPractice/Counter/0/4/1 -> [0,1,2,3,4]eg.
     * api/LoopPractice/Counter/-10/30/10 -> [-10,0,10,20,30]eg.
     * api/LoopPractice/Counter/-10/-17/2 -> [0]eg. 
     * api/LoopPractice/Counter/-10/-17/-2 -> [-10,-12,-14,-1
     * **/
    public class LoopsController : ApiController
    {
        [HttpGet]
        [Route("api/LoopExercise/Counter/{start}/{limit}/{step}")]
        public string Counter(int start, int limit, int step)
        {
            string result = "";
            string delimiter = ",";

            if (step == 0)
            {
                // If step is zero, return an empty string
                return result;
            }

            if ((start < limit && step < 0) || (start > limit && step > 0))
            {
                // If step goes in the wrong direction, return an empty string

                return result;
            }

            for (int i = start; i <= limit; i += step)
            {
                if(i == limit)
                {
                    result += + i + delimiter;
                }
            }

            return result;
        }
    }
}
