//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssessionMapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessionMapping()
        {
            this.BookIssueReturns = new HashSet<BookIssueReturn>();
        }
    
        public int AssessionID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual Book Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssueReturn> BookIssueReturns { get; set; }
    }
}
