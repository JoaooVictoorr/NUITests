using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static UITests.MoreInfoForm;

namespace UITests
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTests : Hooks
    {
        public FirefoxTests() : base(BrowserType.Firefox){}

        [Test]
        public void FirefoxTest()
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