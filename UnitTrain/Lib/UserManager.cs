using System;

namespace Lib
{
    public class UserManager
    {
        public bool Add(string userId, string phone, string email)
        {
            if (userId.Length < 4)
            {
                throw new Exception("UserId shuld have more than 4 sybmbols");
            }

            if (phone.Contains("a"))
            {
                throw new Exception("Telephone shuld contains only digits");
            }

            if (!email.Contains("@"))
            {
                throw new Exception("Email adress mistake");
            }

            return true;
        }
    }
}