using Microsoft.Extensions.Options;
using SportsResultsNotifier.davetn657.Data;
using System.Net;
using System.Net.Mail;

namespace SportsResultsNotifier.davetn657.Services;

public interface IEmailService
{
    /*
     * Send Email 
     * 
     * 
     */
}

public class EmailService : IEmailService
{
    private readonly MailMessage _mail;
    private readonly EmailSettings _settings;

    public EmailService(MailMessage mail, IOptions<EmailSettings> settings)
    {
        _mail = mail;
        _settings = settings.Value;
    }
}