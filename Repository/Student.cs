//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.CallLogs = new HashSet<CallLog>();
        }
    
        public int StudentID { get; set; }
        public string CodeName { get; set; }
        public string Grade { get; set; }
        public Nullable<int> HomeLanguageID { get; set; }
        public string HomeLanguageOther { get; set; }
        public Nullable<bool> HasInternet { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<int> ReferredTypeID { get; set; }
        public bool IsDeleted { get; set; }
        public string GuardianContactNumber { get; set; }
        public string GuardianContactEmail { get; set; }
        public string StudentContactNumber { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool StudentOptOut { get; set; }
        public bool GuardianOptOut { get; set; }
    
        public virtual LanguageType LanguageType { get; set; }
        public virtual ReferredType ReferredType { get; set; }
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallLog> CallLogs { get; set; }
    }
}
