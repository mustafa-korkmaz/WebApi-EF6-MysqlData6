using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class MarketUser
    {
        public MarketUser()
        {
            MarketUserIntegrations = new List<MarketUserIntegration>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Index("IX_Name", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LoginName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Token { get; set; }

        public int MarketId { get; set; } // foreign key 
        public virtual Market Market { get; set; } // navigation property
   
        public virtual ICollection<MarketUserIntegration> MarketUserIntegrations { get; set; } // 1=>n relation

    }
}