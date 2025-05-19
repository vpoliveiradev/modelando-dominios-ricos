using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            if (document == "12345678909")
                return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "vpoliveiradev@gmail.com")
                return true;

            return false;
        }
    }
}