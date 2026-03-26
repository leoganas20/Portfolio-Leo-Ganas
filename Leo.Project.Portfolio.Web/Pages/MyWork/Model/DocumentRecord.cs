namespace Leo.Project.Portfolio.Web.Pages.MyWork.Model;

public class DocumentRecord
{
    public int Id { get; set; }
    public string DocumentName { get; set; }
    public string Category { get; set; }
    public DateTime DateDigitized { get; set; }
    public string Status { get; set; } // Processed, Pending OCR, Archived
    public string FileSize { get; set; }
}
