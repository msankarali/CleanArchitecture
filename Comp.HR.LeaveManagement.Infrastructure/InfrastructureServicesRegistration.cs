using Comp.HR.LeaveManagement.Application.Contracts.Infrastructure;
using Comp.HR.LeaveManagement.Application.Models;
using Comp.HR.LeaveManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Comp.HR.LeaveManagement.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }
    }
}