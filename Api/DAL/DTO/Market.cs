using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class Market
    {
        public int Id { get; set; }

        public Market()
        {
            MarketUsers = new List<MarketUser>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<MarketUser> MarketUsers { get; set; } // 1=>n relation
    }
}