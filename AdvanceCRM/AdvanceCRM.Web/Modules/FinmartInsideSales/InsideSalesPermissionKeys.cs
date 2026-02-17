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
        public const string Read = "InsideSales:Read";

        [Description("Insert")]
        public const string Insert = "InsideSales:Insert";

        [Description("Update")]
        public const string Update = "InsideSales:Update";

        [Description("Delete")]
        public const string Delete = "InsideSales:Delete";

        [Description("Move To Initial Process")]
        public const string MoveToInitialProcess = "InsideSales:Move To InitialProcess";
    }
}
