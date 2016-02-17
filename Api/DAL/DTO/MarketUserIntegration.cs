using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class MarketUserIntegration
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Desc { get; set; }

        public int MarketUserId { get; set; } // foreign key 
        public virtual MarketUser MarketUser { get; set; } // navigation property

        public int IntegrationId { get; set; } // foreign key 
        public virtual Integration Integration { get; set; } // navigation property
    }
}