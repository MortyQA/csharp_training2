using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_testing2
{
     public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
            private string first_name;
            private string middle_name = "";
            private string last_name = "";
            private string nick_name = "";
            private string contact_title;
            private string contact_company = "";
            private string address;
            private string homephone;
            private string mobilephone = "";
            private string workphone = "";
            private string faxphone = "";
            private string contact_hpage;
            private string contact_email;
            private string contact_email2 = "";
            private string contact_email3 = "";
            private string contact_address2;
            private string contact_phone2 = "";
            private string contact_notes = "";
 

        public ContactData(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
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

            public string First_name
            {
                get
                {
                    return first_name;
                }
                set
                {
                    first_name = value;
                }
            }

            public string Middle_name
            {
                get
                {
                    return middle_name;
                }
                set
                {
                    middle_name = value;
                }
            }

            public string Last_name
            {
                get
                {
                    return last_name;
                }
                set
                {
                    last_name = value;
                }
            }

            public string Nick_name
            {
                get
                {
                    return nick_name;
                }
                set
                {
                    nick_name = value;
                }
            }
        
            public string Contact_title
            {
                get
                {
                    return contact_title;
                }
                set
                {
                    contact_title = value;
                }
            }

            public string Contact_company
            {
                get
                {
                    return contact_company;
                }
                set
                {
                    contact_company = value;
                }
            }
        
            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    address = value;
                }
            }  
        
            public string Homephone
            {
                get
                {
                    return homephone;
                }
                set
                {
                    homephone = value;
                }
            }

            public string Mobilephone
            {
                get
                {
                    return mobilephone;
                }
                set
                {
                    mobilephone = value;
                }
            }

            public string Workphone
            {
                get
                {
                    return workphone;
                }
                set
                {
                    workphone = value;
                }
            }

            public string Faxphone
            {
                get
                {
                    return faxphone;
                }
                set
                {
                    faxphone = value;
                }
            }

            public string Contact_hpage
            {
                get
                {
                    return contact_hpage;
                }
                set
                {
                    contact_hpage = value;
                }
            }
        
            public string Contact_email
            {
                get
                {
                    return contact_email;
                }
                set
                {
                    contact_email = value;
                }
            }

            public string Contact_email2
            {
                get
                {
                    return contact_email2;
                }
                set
                {
                    contact_email2 = value;
                }
            }

            public string Contact_email3
            {
                get
                {
                    return contact_email3;
                }
                set
                {
                    contact_email3 = value;
                }
            }

            public string Contact_address2
            {
                get
                {
                    return contact_address2;
                }
                set
                {
                    contact_address2 = value;
                }
            }
            public string Contact_phone2
            {
                get
                {
                    return contact_phone2;
                }
                set
                {
                    contact_phone2 = value;
                }
            }
            public string Contact_notes
            {
                get
                {
                    return contact_notes;
                }
                set
                {
                    contact_notes = value;
                }
            }


     }

}
