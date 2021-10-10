using System.Threading.Tasks;
using Comp.HR.LeaveManagement.Application.Models;

namespace Comp.HR.LeaveManagement.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(Email email);
    }
}