
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.BookIssueReturns = new HashSet<BookIssueReturn>();
        }
    
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public Nullable<int> MemberCategoryID { get; set; }
        public string MemberAddress { get; set; }
        public Nullable<long> ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Remarks { get; set; }
        public Nullable<byte> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssueReturn> BookIssueReturns { get; set; }
        public virtual MemberCategory MemberCategory { get; set; }
    }
}
