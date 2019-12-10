using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class GRNEntry
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        //private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void ATheGRNEntryTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t32"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t32")).Click();
            Task.Delay(2000).Wait();
            
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep"))).SelectByText("Admissions");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_drpDep")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlStoreBU")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBU")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnPOItem")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPoLineDesc_CheckBoxMarkPO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPOLine")).Click();
            Task.Delay(2000).Wait(); 
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CalendarExtender4_day_3_4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate")).Clear();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate")).SendKeys("10/12/2019");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            //Assert.AreEqual("Validation issues\r\n- Enter the Invoice No\r\n- Enter the Purpose", CloseAlertAndGetItsText());
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).SendKeys("123456");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).SendKeys("for office1");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception

            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }

        [Test]
        public void BTheGRNHODTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t32"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t32")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            acceptNextAlert = true;
            Task.Delay(2000).Wait();
            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove")).Click();
            Task.Delay(2000).Wait();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Do You Want To Save & Approve the changes[\\s\\S]$"));
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }


        // The Above Script Works Fine


        [Test]
        public void CTheGRNBuyerTest()
        {
            driver.Navigate().GoToUrl("http://172.16.18.106/PAIS_Selenium/Login.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t59"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t59")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("CODMA");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpdwnBuyerList")).Click();
            Task.Delay(2000).Wait();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpdwnBuyerList"))).SelectByText("buyer");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpdwnBuyerList")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchGRNID")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchGRNID")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_searchGRNID")).SendKeys("231");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button2")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnApprove")).Click();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
