using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _3DP.Areas.Admin.Models.Entities
{
    public class BaseEntity
    {
        public int? State { get; set; }
        [Column(TypeName = "date")]
        private DateTime _time;
        public DateTime ModifyDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreateDate { get { return this._time; } set { _time = value == null ? DateTime.Now : value; } }
        //public string ModifyBy { get; set; }
    }
}