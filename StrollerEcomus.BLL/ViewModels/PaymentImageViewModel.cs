

namespace StrollerEcomus.BLL.ViewModels;

public class PaymentImageViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PaymentImageUrl { get; set; }
}

public class CreatePaymentImageViewModel
{
    public string Name { get; set; } = null!;
    public string PaymentImageUrl { get; set; } = null!;
}

public class UpdatePaymentImageViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PaymentImageUrl { get; set; }

}


