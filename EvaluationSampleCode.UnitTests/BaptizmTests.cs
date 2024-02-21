namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class BaptizmTests
    {


        [TestMethod]
        public void CanBeBaptizedBy_WithPriestClergyMember_ReturnTrue()
        {
            var clergyMember = new ClergyMember();
            clergyMember.IsPriest = true;
            var baptizm = new Baptizm(clergyMember);

            var result = baptizm.CanBeBaptizedBy(clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithPopeClergyMember_ReturnTrue()
        {
            var clergyMember = new ClergyMember();
            clergyMember.IsPope = true;
            var baptizm = new Baptizm(clergyMember);

            var result = baptizm.CanBeBaptizedBy(clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithSimpleClergyMember_ReturnFalse()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);

            var result = baptizm.CanBeBaptizedBy(clergyMember);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WithClergyMember_ReturnTrue()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);

            var result = baptizm.CanBeTeachedBy(clergyMember);

            Assert.IsTrue(result);
        }
    }
}