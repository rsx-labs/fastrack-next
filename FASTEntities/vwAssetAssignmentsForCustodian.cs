//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwAssetAssignmentsForCustodian
    {
        public int AssetAssignmentID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> FixAssetID { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string AssetTag { get; set; }
        public string Brand { get; set; }
        public string AssetRemarks { get; set; }
        public Nullable<int> AssetClassID { get; set; }
        public string ClassDescription { get; set; }
        public Nullable<int> AssetStatusID { get; set; }
        public string StatusDescription { get; set; }
        public Nullable<int> AssetTypeID { get; set; }
        public string TypeDescription { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public Nullable<int> AssignmentStatusID { get; set; }
        public string AssignmentStatus { get; set; }
        public Nullable<System.DateTime> DateAssigned { get; set; }
        public Nullable<System.DateTime> DateReleased { get; set; }
        public string AssignmentRemarks { get; set; }
        public int AdminID { get; set; }
        public int DepartmentID { get; set; }
        public string FromID { get; set; }
        public string ToID { get; set; }
        public string Owner { get; set; }
        public string OwnerDepartment { get; set; }
        public string OwnerEmail { get; set; }
        public string ToName { get; set; }
        public string ToDepartment { get; set; }
        public string ToEmail { get; set; }
        public string FromName { get; set; }
        public string FromDepartment { get; set; }
        public string FromEmail { get; set; }
    }
}