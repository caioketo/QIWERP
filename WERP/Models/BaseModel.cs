using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERP.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public Nullable<DateTime> DataExclusao { get; set; }
    }
}