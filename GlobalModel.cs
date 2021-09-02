using System;
using System.Collections.Generic;
using System.Text;

namespace HRModel
{
    public class GlobalModel
    {
        public List<viewActiveEmployees_HRapp> ActiveEmployeesListData { get; set; }
        public viewActiveEmployees_HRapp viewActiveEmployees_HRapp { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}
