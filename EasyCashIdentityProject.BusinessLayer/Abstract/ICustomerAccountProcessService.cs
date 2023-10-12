using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface ICustomerAccountProcessService : IGenericService<CustomerAccountProcess>
    {
        List<CustomerAccountProcess> TMyLastProcess(int id);
    }
}
