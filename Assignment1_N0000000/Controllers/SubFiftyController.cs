using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N0000000.Controllers
{
    public class SubFiftyController : ApiController
    {
        //Get /api/SubFifty/40 -> -10
        public int Get(int id)
        {
            int difference = id - 50;
            return difference;
        }


    }
}
