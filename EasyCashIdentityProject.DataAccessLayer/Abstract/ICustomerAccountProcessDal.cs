using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountProcessDal : IGenericDal<CustomerAccountProcess>
    {
        List<CustomerAccountProcess> MyLastProcess(int id);
    }
}
