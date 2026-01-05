using Serenity.Services;

namespace AdvanceCRM.Common.Helpers
{
    public class ExcelImportSaveRequest<T> : SaveRequest<T>
        where T : class, new()
    {
        public bool IsExcelImport { get; set; }
    }
}
