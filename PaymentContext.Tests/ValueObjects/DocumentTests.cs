using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Refactor
        [TestMethod]
        public void ReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("1234", Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid, "Validação CNPJ.");
        }
        [TestMethod]
        public void ReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("12345678901234", Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid, "Validação CNPJ.");
        }
        [TestMethod]
        public void ReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("1234", Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid, "Validação CPF.");
        }
        [TestMethod]
        public void ReturnSuccessWhenCPFIsValid()
        {
            var doc = new Document("12345678901", Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Valid, "Validação CPF.");
        }
    }
}