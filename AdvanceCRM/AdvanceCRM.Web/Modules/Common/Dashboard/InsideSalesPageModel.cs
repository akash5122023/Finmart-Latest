
namespace AdvanceCRM.Common
{
    using Administration;
    using System.Collections.Generic;
    using System;    
    using AdvanceCRM.FinmartInsideSales;
    using AdvanceCRM.Operations;

    public class InsideSalesPageModel
    {
        public int OpenMISSales { get; set; }
        public List<InsideSalesRow> InsideSales { get; set; }        
        public int CountOfBirthDayWishes { get; set; }
        public int CountOfAniversaryWishes { get; set; }
        public int CountOfIncorporationWishes { get; set; }
        public Boolean StockData { get; set; }
    }
}