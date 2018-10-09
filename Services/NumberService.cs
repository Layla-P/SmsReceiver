using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SmsReceiver.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace SmsReceiver.Services
{
    public class NumberService
    {
        public Task<List<PhoneNumber>> GetPhoneNumbersAsync()
        {
            throw new NotImplementedException();
        }
        public Task<List<Message>> GetMessagesAsync(string number)
        { 
            throw new NotImplementedException();
        }
    }
}