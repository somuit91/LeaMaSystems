namespace LeaMa.Models.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leama.tbl_agreement_facility")]
    public partial class tbl_agreement_facility
    {
        public int id { get; set; }

        public int? Agreement_No { get; set; }

        [StringLength(150)]
        public string Facility_id { get; set; }

        [StringLength(150)]
        public string Facility_Name { get; set; }

        public int? Numbers_available { get; set; }

        [StringLength(1)]
        public string Delmark { get; set; }

        public virtual tbl_agreement tbl_agreement { get; set; }

        public virtual tbl_facilitymaster tbl_facilitymaster { get; set; }
    }
}
