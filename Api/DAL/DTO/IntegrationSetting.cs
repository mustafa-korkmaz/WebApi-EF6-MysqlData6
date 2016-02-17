using Api.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class IntegrationSetting
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Key { get; set; }

        [Required]
        [MaxLength(100)]
        public string Value { get; set; }

        public int IntegrationId { get; set; } // foreign key
        public virtual Integration Integration { get; set; } // navigation for integration
    }
}