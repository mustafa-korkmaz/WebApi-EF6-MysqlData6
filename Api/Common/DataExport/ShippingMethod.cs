using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Common.DataExport
{
    public class ProductShippingMethod
    {
        public int FirmId { get; set; }
        public string FirmName { get; set; }
        public decimal Cost { get; set; }
    }
}