namespace AdvanceCRM.Common.Helpers {
    export interface ExcelImportSaveRequest<T> extends Serenity.SaveRequest<T> {
        IsExcelImport?: boolean;
    }
}
