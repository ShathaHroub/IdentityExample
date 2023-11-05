using Microsoft.AspNetCore.Identity;

namespace Identitynext2.Models.ViewModel
{
    public class CertificateViewModel 
    {
        public enum ApprovalStatus {
        
        Pending,Approved, Rejected
        }
        public int Id { get; set; }
        public string? CertificateName { get; set; }

        public string? CertificateComp { get; set;}

        public DateTime IssueDate { get; set; }

        public bool ValidTo { get; set; }

        public ApprovalStatus Status { get; set; }
       

    }
}
