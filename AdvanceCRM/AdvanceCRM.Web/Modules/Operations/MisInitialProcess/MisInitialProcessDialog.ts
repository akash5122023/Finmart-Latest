
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisInitialProcessDialog extends DialogBase<MisInitialProcessRow, any> {
        protected getFormKey() { return MisInitialProcessForm.formKey; }
        protected getIdProperty() { return MisInitialProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisInitialProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisInitialProcessRow.nameProperty; }
        protected getService() { return MisInitialProcessService.baseUrl; }
        protected getDeletePermission() { return MisInitialProcessRow.deletePermission; }
        protected getInsertPermission() { return MisInitialProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisInitialProcessRow.updatePermission; }

        protected form = new MisInitialProcessForm(this.idPrefix);
        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            if (Authorization.hasPermission("MISInitialProcess:Move To LogInProcess")) {
                buttons.push({
                    title: 'To LogInProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to LogInProcess',
                    onClick: () => {
                        MisInitialProcessService.MoveToLogInProcess({ //Disable if not applicable
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifyInfo(response.Status);
                                    new Operations.MisLogInProcessDialog().loadByIdAndOpenDialog(response.Id);
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