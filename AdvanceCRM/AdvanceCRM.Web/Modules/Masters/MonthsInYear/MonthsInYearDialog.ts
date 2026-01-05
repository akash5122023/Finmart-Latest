
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MonthsInYearDialog extends Serenity.EntityDialog<MonthsInYearRow, any> {
        protected getFormKey() { return MonthsInYearForm.formKey; }
        protected getIdProperty() { return MonthsInYearRow.idProperty; }
        protected getLocalTextPrefix() { return MonthsInYearRow.localTextPrefix; }
        protected getNameProperty() { return MonthsInYearRow.nameProperty; }
        protected getService() { return MonthsInYearService.baseUrl; }
        protected getDeletePermission() { return MonthsInYearRow.deletePermission; }
        protected getInsertPermission() { return MonthsInYearRow.insertPermission; }
        protected getUpdatePermission() { return MonthsInYearRow.updatePermission; }

        protected form = new MonthsInYearForm(this.idPrefix);

    }
}