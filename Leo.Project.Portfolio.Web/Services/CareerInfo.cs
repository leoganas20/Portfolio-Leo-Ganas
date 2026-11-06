namespace Leo.Project.Portfolio.Web.Services;

public static class CareerInfo
{
    public static readonly DateTime CareerStart = new(2020, 1, 1);

    public static int YearsOfExperience
    {
        get
        {
            var today = DateTime.Today;
            var years = today.Year - CareerStart.Year;
            if (today < CareerStart.AddYears(years))
            {
                years--;
            }
            return years;
        }
    }
}
