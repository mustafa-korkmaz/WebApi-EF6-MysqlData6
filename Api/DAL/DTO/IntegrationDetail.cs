using Api.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Api.DAL.DTO
{
    public class IntegrationDetail
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Url { get; set; }

        [Required]
        public ExportType ExportType { get; set; }

        public int IntegrationId { get; set; } // foreign key
        public virtual Integration Integration { get; set; } // navigation for integration
    }
}