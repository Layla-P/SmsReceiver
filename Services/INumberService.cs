using System.Collections.Generic;
using System.Threading.Tasks;
using SmsReceiver.Models;

namespace SmsReceiver.Services
{
    public interface INumberService
    {
        Task<List<PhoneNumber>> GetPhoneNumbersAsync(); 
        Task<List<Message>> GetMessagesAsync(string number);
    }
}