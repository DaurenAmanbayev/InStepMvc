using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Helpers
{
    public class DateRange : RangeAttribute
    {
        public DateRange() 
            : base(typeof(DateTime), DateTime.MinValue.ToShortDateString(), DateTime.Today.ToShortDateString())
        { }
    }
}