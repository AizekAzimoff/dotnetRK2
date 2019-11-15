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
    public class GroupsRepository : IGroupsRepository
    {
        readonly Context _context;
        
        public GroupsRepository(Context context)
        {
            _context = context;
        }
        public void Add(Group group)
        {
            _context.Add(group);
        }

        public Task<Group> editGroup(int? id)
        {
            return _context.Groups.FindAsync(id);
        }

        public Task<List<Group>> GetAll()
        {
            return _context.Groups.ToListAsync();
        }

        public Task<List<Group>> GetGroups(Expression<Func<Group, bool>> predicate)
        {
            return _context.Groups.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
