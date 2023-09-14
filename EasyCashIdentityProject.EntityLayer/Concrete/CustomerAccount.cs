namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountCurrency { get; set; }
        public decimal? CustomerAccountBalance { get; set; }
        public string? BankBranch { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public List<CustomerAccountProcess> CustomerSender { get; set; }
        public List<CustomerAccountProcess> CustomerReceiver { get; set; }

    }
}
