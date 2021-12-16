using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public string Number { get; private set; }
        public EDocumentType DocumentType { get; private set; }

        public Document(string document, EDocumentType type)
        {
            Number = document;
            DocumentType = type;

            AddNotifications(
                new Contract()
                .Requires()
                .IsTrue(Validade(), "Document.Number", "Comprimento do documento inválido.")
            );
        }
        private bool Validade()
        {
            return (DocumentType == EDocumentType.CPF && Number.Length == 11) || (DocumentType == EDocumentType.CNPJ && Number.Length == 14);
        }
    }
}