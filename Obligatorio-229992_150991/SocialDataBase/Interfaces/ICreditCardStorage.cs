using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface ICreditCardStorage : IStorage<CreditCard>
    {
        IEnumerable<CreditCard> GetAllByCategory(Guid categoryId);
        IEnumerable<CreditCard> GetAllUserCreditCards(Guid userId);
    }
}
