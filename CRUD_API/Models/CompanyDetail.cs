//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyDetail
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyGSTN { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyUserId { get; set; }
        public string CompanyStatus { get; set; }
        public Nullable<System.DateTime> CompanyStartDate { get; set; }
        public string CompanyNatureOfWork { get; set; }
    }
}
