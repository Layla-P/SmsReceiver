using System.Collections.Generic;
using Newtonsoft.Json;

namespace SmsReceiver.Models
{
    public class PhoneNumberWrapper
    {
        [JsonProperty("incoming_phone_numbers")]
        public List<PhoneNumber> PhoneNumbers {get;set;}
    }

    public class PhoneNumber
    {
        [JsonProperty("phone_number")]
        public string Number {get;set;}

        [JsonProperty("friendly_name")]
        public string FriendlyName {get;set;}
    }
}