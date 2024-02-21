namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _helper;
        [TestInitialize]
        public void Init()
        {
            _helper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_WithCorrectString_ReturnHTMLBold()
        {
            var result = _helper.GetStrongFormat("test");

            Assert.IsTrue(result.Contains("<strong>"));
            Assert.IsTrue(result.Contains("test"));
            Assert.IsTrue(result.Contains("</strong>"));
        }
        [TestMethod]
        public void GetStrongFormat_WithUndeclaredString_ReturnHTMLBold()
        {
            var result = _helper.GetStrongFormat("");

            Assert.IsTrue(result.Contains("<strong>"));
            Assert.IsTrue(result.Contains("</strong>"));
        }

        [TestMethod]
        public void GetItalicFormat_WithCorrectString_ReturnHTMLItalic()
        {
            var result = _helper.GetItalicFormat("test");

            Assert.IsTrue(result.Contains("<i>"));
            Assert.IsTrue(result.Contains("test"));
            Assert.IsTrue(result.Contains("</i>"));
        }
        [TestMethod]
        public void GetItalicFormat_WithUndeclaredString_ReturnHTMLItalic()
        {
            var result = _helper.GetItalicFormat("");

            Assert.IsTrue(result.Contains("<i>"));
            Assert.IsTrue(result.Contains("</i>"));
        }

        [TestMethod]
        public void GetFormattedListElements_WithStringObject_ReturnHTMLList()
        {
            var list = new List<string>();
            list.Add("test");
            var result = _helper.GetFormattedListElements(list);

            Assert.IsTrue(result.Contains("<ul>"));
            Assert.IsTrue(result.Contains("</ul>"));
            Assert.IsTrue(result.Contains("<li>"));
            Assert.IsTrue(result.Contains("test"));
            Assert.IsTrue(result.Contains("</li>"));
        }

        [TestMethod]
        public void GetFormattedListElements_WithUndeclaredStringObject_ReturnHTMLEmptyList()
        {
            var list = new List<string>();
            var result = _helper.GetFormattedListElements(list);

            Assert.IsTrue(result.Contains("<ul>"));
            Assert.IsTrue(result.Contains("</ul>"));
        }
    }
}