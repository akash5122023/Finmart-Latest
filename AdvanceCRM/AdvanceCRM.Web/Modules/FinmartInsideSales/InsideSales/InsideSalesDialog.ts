
namespace AdvanceCRM.FinmartInsideSales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class InsideSalesDialog extends DialogBase<InsideSalesRow, any> {
        protected getFormKey() { return InsideSalesForm.formKey; }
        protected getIdProperty() { return InsideSalesRow.idProperty; }
        protected getLocalTextPrefix() { return InsideSalesRow.localTextPrefix; }
        protected getNameProperty() { return InsideSalesRow.nameProperty; }
        protected getService() { return InsideSalesService.baseUrl; }
        protected getDeletePermission() { return InsideSalesRow.deletePermission; }
        protected getInsertPermission() { return InsideSalesRow.insertPermission; }
        protected getUpdatePermission() { return InsideSalesRow.updatePermission; }

        protected form = new InsideSalesForm(this.idPrefix); 
        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            if (Authorization.hasPermission("InsideSales:Move To InitialProcess")) {
                buttons.push({
                    title: 'To InitialProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to InitialProcess',
                    onClick: () => {
                        InsideSalesService.MoveToInitialProcess({ //Disable if not applicable
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifyInfo(response.Status);
                                    new Operations.MisInitialProcessDialog().loadByIdAndOpenDialog(response.Id);
                                }
                                else
                                    Q.notifyError(response.Status)
                            }
                        );
                    }
                });
            }            
            return buttons;
        }
        protected onDialogOpen() {
            super.onDialogOpen();

            if (this.isNew()) {
                this.form.MonthId.value = (new Date().getMonth() + 1).toString();
            }
            if (this.isNew()) {
                this.form.FileReceivedDateTime.value = Q.formatDate(new Date(), 'yyyy-MM-dd');
            }
        }
    }
}