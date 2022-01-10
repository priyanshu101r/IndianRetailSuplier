using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.ExtensionMethods
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Answers true if this string is either null or empty.
        /// </summary>
        /// <remarks>I'm so tired of typing string.IsNullOrEmpty(s)</remarks>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool HasValue(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNull(this object obj)
        {
            bool isNull = obj == null;

            return isNull;
        }

        public static bool IsNotNull(this object obj)
        {
            bool isNotNull = !obj.IsNull();

            return isNotNull;
        }

        public static bool IsNullOrZero(this int? nullableInt)
        {
            return nullableInt == null || nullableInt == 0;
        }

        public static bool IsValidEmail(this string email)
        {
            bool isValidEmail = false;

            if (!email.IsNullOrWhiteSpace())
            {
                isValidEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            }

            return isValidEmail;
        }

        public static bool IsDecimal(this string decimalString)
        {
            decimal convertedString;

            bool tryParseSuccess = decimal.TryParse(decimalString, out convertedString);

            return tryParseSuccess;
        }

        //public static bool IsValidCharacterSeparatedEmails(this string commaSeparatedEmails, char separator = ',')
        //{
        //    string[] emails = commaSeparatedEmails.ToSafeString().Split(separator);

        //    bool isValid = emails.All(email => email.Trim().IsValidEmail());

        //    return isValid;
        //}

        public static bool IsValidUrlPart(this string urlPart)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9-_]+$");

            Match match = regex.Match(urlPart);

            return match.Success;
        }
    }
}
