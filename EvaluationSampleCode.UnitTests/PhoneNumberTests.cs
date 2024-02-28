namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void Parse_ValidNumber_ReturnsPhoneNumberInstance()
        {
            var validNumber = "0123456789";

            var phoneNumber = PhoneNumber.Parse(validNumber);

            Assert.IsNotNull(phoneNumber);
            Assert.AreEqual("012", phoneNumber.Area);
            Assert.AreEqual("345", phoneNumber.Major);
            Assert.AreEqual("6789", phoneNumber.Minor);
        }

        [TestMethod]
        public void Parse_NullNumber_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(null));
        }

        [TestMethod]
        public void Parse_EmptyNumber_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(""));
        }

        [TestMethod]
        public void Parse_WhiteSpaceNumber_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("   "));
        }

        [TestMethod]
        public void Parse_InvalidLengthNumber_ThrowsArgumentException()
        {
            var invalidNumber = "123456789";

            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(invalidNumber));
        }

        [TestMethod]
        public void ToString_ValidPhoneNumber_ReturnsFormattedString()
        {
            PhoneNumber phoneNumber = PhoneNumber.Parse("0123456789");

            var result = phoneNumber.ToString();

            Assert.AreEqual("(012)345-6789", result);
        }
    }
}