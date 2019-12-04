using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static UITests.MoreInfoForm;

namespace UITests
{
    [TestFixture]
    public class ChromeTests : Hooks
    {
        public ChromeTests() : base(BrowserType.Chrome){}

        [Test]
        public void ChromeTest()
        {
            NavBar navBar = new NavBar();
            MoreInfoForm form = new MoreInfoForm();
            MoreInfoFormData data = new MoreInfoFormData()
            {
                nome = "João Victor Silveira Piccoli",
                email = "jvpiccoli@gmail.com",
                empresa = "Relevo",
                cargo = "Analista de Teste",
                telefone = "999328908",
                cidade = "Juiz de Fora",
                estado = "Minas Gerais"
            };

            navBar
                .GoTo("Mais Informações");
            form
                .FillFields(data);
        }
    }
}
