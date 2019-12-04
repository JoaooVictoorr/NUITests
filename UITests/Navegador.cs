using NUnit.Framework;
namespace UITests
{
    public class Navegador : BaseClass
    {
        public void GoTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Assert.That(Driver.Url.Contains(url), Is.EqualTo(true), "The URL is Wrong");
        }
    }
}
