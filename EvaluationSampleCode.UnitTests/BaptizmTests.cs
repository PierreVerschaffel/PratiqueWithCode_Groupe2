namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class BaptizmTests
    {
        private ClergyMember _clergyMember;

        [TestInitialize]
        public void Init()
        {
            _clergyMember = new ClergyMember();
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithAClergyMember_ReturnFalse()
        {
            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeBaptizedBy(_clergyMember);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithAClergyMember_ReturnTrue()
        {
            var baptizm = new Baptizm(_clergyMember);

            var result = baptizm.CanBeTeachedBy(_clergyMember);

            Assert.IsTrue(result);
        }
    }
}