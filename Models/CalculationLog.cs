using System;
//using System.Data.Entity; (which would need to be added to NuGet)

namespace JoshuaBaeslerApp.Models
{
    public class CalculationLog
    {
        public int input1 { get; set; }
        public int input2 { get; set; }
        public int? input3 { get; set; }
        public string shape { get; set; }
        public string calculationType { get; set; }
        public DateTime calculationTime { get; set; }

    }


    /*
     * This section of the Model would be used to post this data to a database, 
     * so the logs of each calculation can be viewed there
     * 
     * public class CalculationLogContext: DbContext
     * {
     *  public Dbset<CalculationLog> Logs { get; set; }
     *  }
     */
}