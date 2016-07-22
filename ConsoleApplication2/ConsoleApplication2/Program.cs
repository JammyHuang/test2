using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Selenium;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISelenium selenium =
                new DefaultSelenium("localhost", 4444, "*iexplore", "http://192.168.1.1/");
                                                //firefox//googlechrome//iexplore
            selenium.Start();

            selenium.SetSpeed("500");
            selenium.Open("/config");
            selenium.WindowMaximize();
            selenium.Type("id=ACT0", "root");
            selenium.Type("id=PWD0", "00000000");
            selenium.Click("id=APY0");
            selenium.WaitForPageToLoad("30000");         

            //
            selenium.Click("id=advancedFunction");
            selenium.Click("id=dataLog");
            selenium.Click("link=Logger Configuration");
            selenium.Click("id=memDEn");
            //selenium.Click("css=span.SliderSwitch-switch");
            selenium.Click("id=memSEn");
            //selenium.Click("//div[@id='panelLoggerConfig']/div/form/div[2]/div/div/div/div/label/span");
            selenium.Click("id=cloudEn");
            selenium.Click("css=#cloudUploadSetting > div.form-group.row > div.col-lg-12 > div.col-sm-10 > div.input-group > div.SliderSwitch > label.SliderSwitch-label > span.SliderSwitch-switch");
            selenium.Select("id=logFn", "label=YYYYMMDD");
            selenium.Select("id=logTmF", "label=Local Date and Time(GMT)");
            selenium.Select("id=selDEn", "label=Item Periodic Interval mode");
            selenium.Type("id=inpDItm", "1");
            selenium.Type("id=inpDTag", "8989");
            selenium.Select("id=selSEn", "label=Item Periodic Interval mode");
            selenium.Type("id=inpSItm", "52");
            selenium.Type("id=inpSTag", "5656");
            selenium.Click("id=pushDEn");
            selenium.Click("css=#push_output > div.form-group.row > div.col-lg-12 > div.col-sm-10 > div.input-group > div.SliderSwitch > label.SliderSwitch-label > span.SliderSwitch-inner");
            selenium.Click("id=pushSEn");
            selenium.Click("//span[@id='push_output']/div[2]/div/div/div/div/label/span");
            selenium.Click("id=logMAC");
            selenium.Click("id=logTIM");
            selenium.Click("id=logTIM");
            selenium.Select("id=selTmF", "label=Local Date and Time(GMT)");
            selenium.Click("id=btnLoggerConfigSubmit");

            selenium.Stop();



        }
    }
}
