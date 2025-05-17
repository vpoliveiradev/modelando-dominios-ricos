using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var document = new Document("123", EDocumentType.CNPJ);
            Assert.IsFalse(document.IsValid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var document = new Document("91195160000199", EDocumentType.CNPJ);
            Assert.IsTrue(document.IsValid);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var document = new Document("123", EDocumentType.CPF);
            Assert.IsFalse(document.IsValid);

        }

        //outra alternativa caso queira testar N cpfs
        [TestMethod]
        [DataTestMethod]
        [DataRow("12345678909")]
        [DataRow("71489793070")]
        [DataRow("42836843098")]
        [DataRow("63947400047")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(document.IsValid);
        }
    }
}