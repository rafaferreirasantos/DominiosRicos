using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

public class StudentTests
{

    public void AdicionarAssinatura()
    {
        var student = new Student(
            new Name("Rafael", "Santos"),
            new Document("33372656857", Domain.Enums.EDocumentType.CPF),
            new Email("osmarditto@gmail.com"));

        var subscription = new Subscription(null);
        var payment = new BoletoPayment(
            "1234567890",
            "54321",
            DateTime.Now,
            DateTime.Now,
            199,
            199,
            new Document("33372656857", Domain.Enums.EDocumentType.CPF),
            "Rafael F Santos",
            new Address("Travessa Itaúna", "80", "Campestre", "Santo André", "SP", "Brasil", "09080210"),
            new Email("osmarditto@gmail.com"));

        student.AddSubscription(subscription);
    }
}