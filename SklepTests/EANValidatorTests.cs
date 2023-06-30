using Sklep.Utils;

namespace SklepTests
{
    [TestClass]
    public class EANValidatorTests
    {
        [TestMethod]
        public void ValidCodes()
        {
            var barcodes = new[] { "9788381882118", "1234567890128" };
            foreach(var code in barcodes)
            {
                Assert.IsTrue(EANValidator.validateBarcode(code), "Code " + code + " should be valid");
            }
        }

        [TestMethod]
        public void InalidCodes()
        {
            var barcodes = new[] { "9788381882117", "1234567890123", "123456789012", "qwertyasdfghz" };
            foreach (var code in barcodes)
            {
                Assert.IsFalse(EANValidator.validateBarcode(code), "Code " + code + " should be invalid");
            }
        }
    }
}