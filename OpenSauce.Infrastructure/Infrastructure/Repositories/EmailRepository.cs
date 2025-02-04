using Infrastructure.Contexts;
using Infrastructure.Models;

namespace Infrastructure.Repositories
{
    public class EmailRepository : Repository<Email>
    {
        public EmailRepository(Context context) : base(context)
        {
        }   
    }
}