using Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class IntegrationModel
    {
        public string Content { get; set; } // integration content
        public string MediaType { get; set; } // e.g application/json
    }
    public class IntegrationInfoModel
    {
        public string Name { get; set; }
        public IntegrationType Type { get; set; } // opencart, magento?
        public IntegrationStatus Status { get; set; } // active, passive?
    }

}