using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_testing2
{
     public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public ContactData(string first_name, string last_name)
        {
            First_name = first_name;
            Last_name = last_name;
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
            return First_name == other.First_name & Last_name == other.Last_name;
        }

        public override int GetHashCode()
        {
            return First_name.GetHashCode() & Last_name.GetHashCode();
        }

        public override string ToString()
        {
            return First_name + " " + Last_name;
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
            public string Id { get; set; }
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

     }
}
