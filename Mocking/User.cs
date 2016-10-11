using System;

namespace Mocking
{
    public enum Rights { None, Limited, Full }
    public class User
    {
        public User()
        {
        }

        public string Password { get; set; }
        public Rights Rights { get; internal set; }

        public string UserName { get; set; }

        internal string ViewAllEmployees()
        {
            if (Rights == Rights.Full)
                return "Here is the list";
            else
                return "Kind sir you don't seem to have the rights for that action";
        }
    }
}