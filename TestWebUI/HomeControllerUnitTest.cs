using Microsoft.VisualStudio.TestTools.UnitTesting;
using jeudontonestlehéros.Web.UI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestWebUI
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void TestAboutIsOk()
        {
            HomeController controller = new HomeController();

            var result = controller.Privacy();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = result as ViewResult;

            Assert.IsNotNull(viewResult.ViewData["Title"]);
            Assert.IsTrue(viewResult.ViewData["Title"].ToString() == "Privacy Policies");
        }
    }
}
