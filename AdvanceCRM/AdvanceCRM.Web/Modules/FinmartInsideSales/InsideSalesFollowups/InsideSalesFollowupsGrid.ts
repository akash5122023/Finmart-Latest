namespace AdvanceCRM.FinmartInsideSales {

    @Serenity.Decorators.registerClass()
    export class InsideSalesFollowupsGrid extends Serenity.EntityGrid<InsideSalesFollowupsRow, any> {
        protected getColumnsKey() { return 'FinmartInsideSales.InsideSalesFollowups'; }
        protected getDialogType() { return InsideSalesFollowupsDialog; }
        protected getIdProperty() { return InsideSalesFollowupsRow.idProperty; }
        protected getInsertPermission() { return InsideSalesFollowupsRow.insertPermission; }
        protected getLocalTextPrefix() { return InsideSalesFollowupsRow.localTextPrefix; }
        protected getService() { return InsideSalesFollowupsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
            this.element.find('.quick-filters-bar').toggle(false);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem({ InsideSalesId: this.insideSalesId });
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.insideSalesId;
        }

        private _insideSalesId: string;

        get insideSalesId() {
            return this._insideSalesId;
        }

        set insideSalesId(value: string) {
            if (this._insideSalesId !== value) {
                this._insideSalesId = value;
                this.setEquality('InsideSalesId', value);
                this.refresh();
            }
        }
    }
}
