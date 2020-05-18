using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_testing2
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper AddNewContactName(ContactData cname)
        {
            manager.Navigator.GoToAddNew();
            ContactNameInformation(cname);
            AddContact();
            return this;
        }

        public ContactHelper Modify(ContactData newName)
        {
            manager.Navigator.GoToHome();
            ContactModification(0);
            ContactNameInformation(newName);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Remove(int p)
        {
            manager.Navigator.GoToHome();
            SelectContact(p);
            RemoveContact();
            AcceptRemove();
            return this;
        }

        public ContactHelper ContactExists()
        {
            if (!FindContact())
            {
                manager.Navigator.GoToAddNew();
                AddContact();
                manager.Navigator.GoToHome();
            }

            return this;

        }

        public bool FindContact()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public ContactHelper ContactNameInformation(ContactData contact_name)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact_name.First_name);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact_name.Middle_name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact_name.Last_name);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contact_name.Nick_name);
            return this;
        }

        public ContactHelper ContactWorkInformation(ContactData cwork)
        {
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(cwork.Contact_title);
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(cwork.Contact_company);
            return this;
        }

        public ContactHelper ContactAddress(ContactData caddress)
        {
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(caddress.Address);
            return this;
        }

        public ContactHelper ContactPhoneInformation(ContactData cphone)
        {
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(cphone.Homephone);
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(cphone.Mobilephone);
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(cphone.Workphone);
            driver.FindElement(By.Name("fax")).Click();
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(cphone.Faxphone);
            return this;
        }

        public ContactHelper ContactEmailInformation(ContactData cemail)
        {
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(cemail.Contact_email);
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(cemail.Contact_email2);
            driver.FindElement(By.Name("email3")).Click();
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(cemail.Contact_email3);
            return this;
        }

        public ContactHelper ContactHomePage(ContactData chpage)
        {
            driver.FindElement(By.Name("homepage")).Click();
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(chpage.Contact_hpage);
            return this;
        }

        public ContactHelper ContactBirthday()
        {
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            driver.FindElement(By.Name("bmonth")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys("2020");
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("4");
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("March");
            driver.FindElement(By.Name("amonth")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys("2020");
            return this;
        }

        public ContactHelper SelectContactGroup()
        {
            driver.FindElement(By.Name("new_group")).Click();
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("aaa");
            return this;
        }

        public ContactHelper ContactSecondary(ContactData secondary)
        {
            driver.FindElement(By.Name("address2")).Click();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(secondary.Contact_address2);
            driver.FindElement(By.Name("phone2")).Click();
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(secondary.Contact_phone2);
            driver.FindElement(By.Name("notes")).Click();
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(secondary.Contact_notes);
            return this;
        }

        public ContactHelper AddContact()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper AcceptRemove()
        {
            Assert.IsTrue(Regex.IsMatch(manager.CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper ContactModification(int index)
        {
            driver.FindElements(By.Name("entry"))[index]
                .FindElements(By.TagName("td"))[7]
                .FindElement(By.TagName("a")).Click();
            return this;
        }

        public ContactHelper ContactDetails()
        {
            driver.FindElement(By.XPath("//img[@alt='Details']")).Click();
            return this;
        }

        public ContactHelper AddTo()
        {
            driver.FindElement(By.Name("add")).Click();
            return this;
        }

        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.GoToHome();
                ICollection<IWebElement> elements = driver.FindElements(By.XPath("(//tr[@name='entry'])"));
                foreach (IWebElement element in elements)
                {
                    IList<IWebElement> cells = element.FindElements(By.TagName("td"));
                    string firstname = cells[2].Text;
                    string lastname = cells[1].Text;
                    contactCache.Add(new ContactData(firstname, lastname) {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
            }
            return contactCache;
        }

        public int GetContactCount()
        {
            manager.Navigator.GoToHome();
            return driver.FindElements(By.XPath("(//tr[@name='entry'])")).Count;
        }

        public ContactData GetContactInformationFromEditForm(int index)
        {
            manager.Navigator.GoToHome();
            ContactModification(0);

            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

            string email = driver.FindElement(By.Name("email")).GetAttribute("value");
            string email2 = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string email3 = driver.FindElement(By.Name("email3")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                Homephone = homePhone,
                Mobilephone = mobilePhone,
                Workphone = workPhone,
                Contact_email = email,
                Contact_email2 = email2,
                Contact_email3 = email3
            };

        }

        internal ContactData GetContactInformationFromTable(int index)
        {
            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index].FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allEmails = cells[4].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones,
                AllEmails = allEmails,
            };
        }

        public int GetNumberOfSearchResult()
        {
            manager.Navigator.GoToHome();
            string text = driver.FindElement(By.TagName("label")).Text;
            Match m =  new Regex(@"\d+").Match(text);
            return Int32.Parse(m.Value);
        }
    }
}
