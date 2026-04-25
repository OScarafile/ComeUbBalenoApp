// Interfaccia PayPal. TODO: integrare SDK PayPal reale.
// SICUREZZA: non inserire mai credenziali nel codice. Usare User Secrets o variabili d'ambiente.
namespace ComeUbBalenoApp.BLL.Interfaces;

/// <summary>Risultato della creazione di un pagamento PayPal.</summary>
public class PayPalPaymentResult
{
    public bool Success { get; set; }
    public string? PaymentId { get; set; }
    public string? ApprovalUrl { get; set; }
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// Interfaccia servizio PayPal.
/// TODO: implementare con SDK PayPal reale. Vedere: https://developer.paypal.com/docs/api/orders/v2/
/// </summary>
public interface IPayPalService
{
    /// <summary>
    /// Crea un pagamento PayPal.
    /// TODO: usare User Secrets per ClientId e ClientSecret. NON mettere credenziali nel codice!
    /// </summary>
    Task<PayPalPaymentResult> CreatePaymentAsync(int orderId, decimal amount, string currency = "EUR", CancellationToken cancellationToken = default);
}
