using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class Part2Controller : ApiController
    {

        /// <summary>
        /// Question from CCC 2007, Problem J2: I Speak TXTMSG. 
        /// Using abbreviation to get text.
        /// </summary>
        /// <param name="sText">Abbreviative text</param>
        /// <returns>Meaning of the abbreviative text</returns>
        /// <example>  
        ///         Get : /api/part2/TXTMSG/CU          - >     see you
        /// </example>
        [HttpGet]
        [Route("api/part2/TXTMSG/{sText}")]

       public string GetTXTMSG(string sText)
        {
                         
            if (sText == "CU")
            {
                return ("see you");
            }
            else if (sText == ":-)")
            {
                return ("I'm happy.");
            }
            else if (sText == ":-(")
            {
                return ("I'm unhappy.");
            }
            else if (sText == ";-)")
            {
                return ("wink");
            }
            else if (sText == ":-P")
            {
                return ("stick out my tongue");
            }
            else if (sText == "(~.~)")
            {
                return ("sleepy");
            }
            else if (sText == "TA")
            {
                return ("Totally awesome");
            }
            else if (sText == "CCC")
            {
                return  ("Canadian Computing Competition");
            }
            else if (sText == "CUZ")
            {
                return ("because");
            }
            else if (sText == "TY")
            {
                return ("Thank you");
            }
            else if (sText == "YW")
            {
                return ("You're welcome");
            }
            else if (sText == "TTYL")
            {
                return ("talk you later");
            }

            return "Hello";
        }
                
    }
}



