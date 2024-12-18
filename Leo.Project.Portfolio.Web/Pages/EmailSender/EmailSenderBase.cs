using Leo.Project.Portfolio.Web.Pages.EmailSender.Model;
using Leo.Project.Portfolio.Web.Services;
using Leo.Projects.Portfolio.Web.Pages.ComponentPageBase;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Leo.Project.Portfolio.Web.Pages.EmailSender;


public class EmailSenderBase : ComponentPageBase
{
    [Inject] public required RequestEmailService RequestEmail { get; set; }
    [Inject] public ISnackbar snackbar { get; set; }
    protected EmailRequestParameterable EmailRequest = new EmailRequestParameterable();

    protected async Task SendEmail(EmailRequestParameterable model)
    {
        IsVisible = true;

        if(string.IsNullOrEmpty(model.SenderEmail) || string.IsNullOrEmpty(model.Subject) || string.IsNullOrEmpty(model.Body))
        {
            snackbar.Add("Please enter the required fields!", Severity.Error);
            return;
        }
        var res = await RequestEmail.SendEmail(model.SenderEmail, model.Subject, model.Body);
        
        if (!string.IsNullOrEmpty(res))
        {
            snackbar.Add("Email sent !", Severity.Success);
          
        }

        IsVisible = false;
    }

}