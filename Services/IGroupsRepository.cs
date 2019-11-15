using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using midterm.Data;
using midterm.Models;

namespace midterm.Services
{
    public interface IGroupsRepository
    {
        void Add(Group group);
        Task Save();
        Task<List<Group>> GetAll();
        Task<Group> editGroup(int? id);
        Task<List<Group>> GetGroups(Expression<Func<Group, bool>> predicate);
    }
}
