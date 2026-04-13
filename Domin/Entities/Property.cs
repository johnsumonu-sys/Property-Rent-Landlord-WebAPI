using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class Property
    {
    public Guid Id {get; set;}
    public string Title {get; set;} // "A Mini Flat at Ijaiye 
    
    public string Description {get; set;}   
    public string Location {get; set;} // City or area
    public string Address {get; set;} // Full address
    public decimal RentAmount {get; set;}
    public RentFrequency RentFrequency {get; set;}
    public PropertyType PropertyType {get; set;}
    public PropertyApprovalStatus PropertyApprovalStatus { get; set; } = PropertyApprovalStatus.PENDING_APPROVAL;
    public PropertyAvailabilityStatus PropertyAvailabilityStatus { get; set; } = PropertyAvailabilityStatus.AVAILABLE;
    public string? RejectionReason {get; set;}
    // Foreign Key
    public Guid Landlord { get; set;}
    // Navigation Property 
    public User Landlord { get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;



    }
}
