
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisLogInProcessDialog extends DialogBase<MisLogInProcessRow, any> {
        protected getFormKey() { return MisLogInProcessForm.formKey; }
        protected getIdProperty() { return MisLogInProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisLogInProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisLogInProcessRow.nameProperty; }
        protected getService() { return MisLogInProcessService.baseUrl; }
        protected getDeletePermission() { return MisLogInProcessRow.deletePermission; }
        protected getInsertPermission() { return MisLogInProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisLogInProcessRow.updatePermission; }

        protected form = new MisLogInProcessForm(this.idPrefix);
        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            if (Authorization.hasPermission("MISLogInProcess:Move To DisbursementProcess")) {
                buttons.push({
                    title: 'To DisbursementProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to DisbursementProcess',
                    onClick: () => {
                        MisLogInProcessService.MoveToDisbursementProcess({ //Disable if not applicable
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifyInfo(response.Status);
                                    new Operations.MisDisbursementProcessDialog().loadByIdAndOpenDialog(response.Id);
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
    }
}