
namespace AdvanceCRM.Common
{
    using Administration;
    using System.Collections.Generic;
    using System;
    using AdvanceCRM.FinmartInsideSales;
    using AdvanceCRM.Operations;

    public class SalesOperationsDashboardPageModel
    {
        // InsideSales data
        public int OpenMISSales { get; set; }
        public List<InsideSalesRow> InsideSales { get; set; }

        // Operations - Initial Process data
        public int OpenMISInitialProcess { get; set; }

        // Operations - Login Process data
        public int OpenMISLoginProcess { get; set; }

        // Operations - Disbursement Process data
        public int OpenMISDisbursementProcess { get; set; }

        // Common properties
        public int CountOfBirthDayWishes { get; set; }
        public int CountOfAniversaryWishes { get; set; }
        public int CountOfIncorporationWishes { get; set; }
        public Boolean StockData { get; set; }

        // Permission flags for role-based visibility
        public bool CanViewInsideSales { get; set; }
        public bool CanViewInitialProcess { get; set; }
        public bool CanViewLoginProcess { get; set; }
        public bool CanViewDisbursementProcess { get; set; }
    }
}
