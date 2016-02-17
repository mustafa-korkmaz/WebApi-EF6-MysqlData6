using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Common.DataExport
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public string ParentCategoryName { get; set; }
    }

}