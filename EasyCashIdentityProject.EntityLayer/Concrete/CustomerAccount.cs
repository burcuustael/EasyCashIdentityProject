namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountCurrency { get; set; }
        public decimal? CustomerAccountBalance { get; set; }
        public string? BankBranch { get; set; }
    }
}
