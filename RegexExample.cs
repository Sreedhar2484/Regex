using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExample
{
    internal class Regex1
    {
        public static bool IsValidMobileNumber(string phoneNumber)
        {
            // Regular expression pattern for a 10-digit mobile number
            string pattern = @"^[0-9]{10}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Matches method to check if the phone number matches the pattern
            Match match = regex.Match(phoneNumber);

            // Return true if there is a match, false otherwise
            return match.Success;
        }

    }
}
