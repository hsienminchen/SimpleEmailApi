namespace SimpleEmailApi.Service.EmailService
{
    public interface IEmailService
    {
        void SendMail(EmailDto request);
    }
}
