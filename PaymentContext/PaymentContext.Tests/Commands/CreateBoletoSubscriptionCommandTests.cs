using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand
            {
                FirstName = "",
                LastName = "Wayne",
                Document = "12345678909",
                Email = ""
            };

            command.Validate();
            Assert.AreEqual(false, command.IsValid);
        }
    }
}