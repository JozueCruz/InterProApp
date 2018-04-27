using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowBox_TestAut.WebDriversComponents.WebDriverObjects
{
    class UserLogInObjects
    {
        private string userName;
        private string passwordUser;
        private string testCase;
        private string expectedResult;
        private string browser;
        private string menu;
        private string subMenu;
        private string subSubMenu;
        private string url;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string PasswordUser
        {
            get { return passwordUser; }
            set { passwordUser = value; }
        }

        public string TestCase
        {
            get { return testCase; }
            set { testCase = value; }
        }

        public string ExpectedResult
        {
            get { return expectedResult; }
            set { expectedResult = value; }
        }

        public string Browser
        {
            get { return browser; }
            set { browser = value; }
        }

        public string Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public string SubMenu
        {
            get { return subMenu; }
            set { subMenu = value; }
        } 

        public string SubSubMenu
        {
            get { return subSubMenu; }
            set { subSubMenu = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
