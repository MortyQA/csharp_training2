﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace addressbook_testing2
{
     public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;
        private string allEmails;
        private int id;

        public ContactData(string first_name, string last_name, int id, string address, string homephone, string mobilephone, string workphone, string faxphone, string contact_email)
        {
            First_name = first_name;
            Last_name = last_name;
            Id = int.MaxValue;
            Homephone = homephone;
            Mobilephone = mobilephone;
            Workphone = workphone;
            Faxphone = faxphone;
            Contact_email = contact_email;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return id== other.id & First_name == other.First_name & Last_name == other.Last_name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() & First_name.GetHashCode() & Last_name.GetHashCode();
        }

        public override string ToString()
        {
            return Id + " " + First_name + " " + Last_name;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(Last_name, null))
            {
                if (Last_name == other.Last_name)
                {
                    Object.ReferenceEquals(First_name, null);
                    return 1;
                }
            }
                return Last_name.CompareTo(other.Last_name);           
        }

            public string First_name { get; set; }
            public string Middle_name { get; set; }
            public string Last_name { get; set; }
            public string Nick_name { get; set; }       
            public int Id { get; set; }
            public string Contact_title { get; set; }
            public string Contact_company { get; set; }        
            public string Address { get; set; }        
            public string Homephone { get; set; }
            public string Mobilephone { get; set; }
            public string Workphone { get; set; }
            public string Faxphone { get; set; }
            public string Contact_hpage { get; set; }       
            public string Contact_email { get; set; }
            public string Contact_email2 { get; set; }
            public string Contact_email3 { get; set; }
            public string Contact_address2 { get; set; }
            public string Contact_phone2 { get; set; }
            public string Contact_notes { get; set; }           

        public string AllEmails
        {
            get
            {
                if (allEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return Contact_email + Contact_email2 + Contact_email3.Trim();
                }
            }
            set
            {
                allEmails = value;
            }
        }

        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return CleanUp(Homephone) + CleanUp(Mobilephone) + CleanUp(Workphone).Trim();
                }
            }
            set
            {
                allPhones = value;
            }
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
           return Regex.Replace(phone, "[ -()]", "") + "\r\n";
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
