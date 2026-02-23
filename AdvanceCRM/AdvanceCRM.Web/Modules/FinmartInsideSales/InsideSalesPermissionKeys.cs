using Serenity.ComponentModel;
using Serenity.Web;
using System.ComponentModel;

namespace AdvanceCRM.FinmartInsideSales
{
    [NestedPermissionKeys]
    [DisplayName("Inside Sales")]
    public class PermissionKeys
    {
        [Description("Read")]
        [ImplicitPermission("Contacts:Read")]
        public const string Read = "InsideSales:Read";

        [Description("Insert")]
        [ImplicitPermission("Contacts:Insert")]
        public const string Insert = "InsideSales:Insert";

        [Description("Update")]
        [ImplicitPermission("Contacts:Update")]
        public const string Update = "InsideSales:Update";

        [Description("Delete")]
        [ImplicitPermission("Contacts:Delete")]
        public const string Delete = "InsideSales:Delete";

        [Description("Move To Initial Process")]
        public const string MoveToInitialProcess = "InsideSales:Move To InitialProcess";
    }
}
