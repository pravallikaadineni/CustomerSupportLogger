﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVC.Models
{
    public class CustModel
    {
        public int logid { get; set; }
        public string custemail { get; set; }

        public string custname { get; set; }
        public string logstatus { get; set; }

        public string description { get; set; }

        public int userid { get; set; }
    }
}