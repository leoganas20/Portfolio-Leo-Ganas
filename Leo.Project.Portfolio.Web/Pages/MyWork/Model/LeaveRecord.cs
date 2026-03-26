namespace Leo.Project.Portfolio.Web.Pages.MyWork.Model;

public class LeaveRecord
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string LeaveType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } // Approved, Pending, Rejected
}
