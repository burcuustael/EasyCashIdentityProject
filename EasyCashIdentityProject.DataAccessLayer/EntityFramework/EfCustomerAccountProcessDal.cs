using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.DataAccessLayer.Repositories;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDal
    {
        public EfCustomerAccountProcessDal(Context context) : base(context)
        {
        }

        public List<CustomerAccountProcess> MyLastProcess(int id)
        {
            using var context = new Context();
            var values = context.CustomerAccountProcesses.Include(y=>y.CustomerAccount).Where(x=>x.ReceiverId== id || x.SenderId==id).ToList();
            return values;
        }
    }
}
