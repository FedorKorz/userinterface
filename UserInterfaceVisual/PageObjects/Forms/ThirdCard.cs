using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceVisual.PageObjects.Forms
{
    public class ThirdCard : Form
    {
        public ThirdCard() : base(By.XPath("//div[@class='personal-details__form']"), "Third Card")
        {

        }
    }
}
