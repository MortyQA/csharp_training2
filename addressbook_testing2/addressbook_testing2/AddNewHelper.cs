using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_testing2
{
        public class ContactName
        {
            private string first_name;
            private string middle_name = "";
            private string last_name = "";
            private string nick_name = "";

            public ContactName(string first_name)
            {
            this.first_name = first_name;
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
        }

        public class ContactWork
        {
            private string contact_title;
            private string contact_company = "";

            public ContactWork(string contact_title)
            {
            this.contact_title = contact_title;
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
        }

        public class ContactAddress
        {
            private string address;

            public ContactAddress(string address)
            {
            this.address = address;
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
        }

        public class ContactPhone
        {
            private string homephone;
            private string mobilephone = "";
            private string workphone = "";
            private string faxphone = "";

            public ContactPhone(string homephone)
            {
            this.homephone = homephone;
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

        }
        public class ContactHomepage
        {
            private string contact_hpage;

            public ContactHomepage(string contact_hpage)
            {
            this.contact_hpage = contact_hpage;
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
        }
        public class ContactEmail
        {
            private string contact_email;
            private string contact_email2 = "";
            private string contact_email3 = "";

            public ContactEmail(string contact_email)
            {
            this.contact_email = contact_email;
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
                    return contact_email;
                }
                set
                {
                    contact_email = value;
                }
            }

            public string Contact_email3
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

        }
        public class ContactSecondary
        {
            private string contact_address2;
            private string contact_phone2 = "";
            private string contact_notes = "";

            public ContactSecondary(string contact_address2)
            {
            this.contact_address2 = contact_address2;
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
//}
