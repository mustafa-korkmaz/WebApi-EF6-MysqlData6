using Api.Common.DataExport;
using System.Collections.Generic;
using Api.BL.Helper;

namespace Api.BL.DataExport
{
    public class CategoryExporter : IDataExportable
    {
        private List<Category> _categories { get; set; }

        public CategoryExporter(List<Category> categories)
        {
            _categories = categories;
        }

        public string ExportData()
        {
            return _categories.Serialize();
        }
    }
}