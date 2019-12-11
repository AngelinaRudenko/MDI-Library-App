using System;

namespace Library
{
    [Serializable]
    class UsersClass
    {
        public string username, surname, department, group, address, phone;

        public UsersClass(string username, string surname, string department, string group, string address, string phone)
        {
            this.username = username;
            this.surname = surname;
            this.department = department;
            this.group = group;
            this.address = address;
            this.phone = phone;
        }
        public UsersClass() : this("-", "-", "-", "-", "-", "-") { }
    }
}
