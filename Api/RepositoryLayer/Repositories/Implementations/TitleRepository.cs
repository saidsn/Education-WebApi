using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        public TitleRepository(AppDbContext context) : base(context)
        {

        }
    }
}
