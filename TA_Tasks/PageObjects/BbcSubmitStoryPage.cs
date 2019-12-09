﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TA_Tasks.PageObjects
{
    public class BbcSubmitStoryPage
    {
        private IWebDriver Driver => WebDriverBase.GetDriver();
        private static string XpathBase = "//label[contains(text(), '{0}')]/following-sibling::*";
        private static string Send_button = "//input[contains(@type, 'submit')]";

        Form Form2 = new Form(XpathBase, Send_button);

        public BbcSubmitStoryPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void FillForm(Dictionary<string, string> values)
        {
            Form2.FillForm(values);
        }

        public void CheckField(string check_field)
        {
            Form2.CheckField(check_field);
        }

        public bool CheckForm()
        {
            return Form2.CheckForm();
        }
    }
}
