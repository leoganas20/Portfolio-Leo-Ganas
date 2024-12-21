namespace Leo.Project.Portfolio.Web.Pages.MyWork.Model;

public class InspectionData
{
    public int AssetId { get; set; }
    public string AssetType { get; set; }
    public DateTime InspectionDate { get; set; }
    public int ConditionRating { get; set; }
    public string Defects { get; set; }
    public string InspectionNotes { get; set; }
    public DateTime NextInspectionDue { get; set; }
    public string Status { get; set; }
}