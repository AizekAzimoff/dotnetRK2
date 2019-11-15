using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using midterm.Data;
using midterm.Models;

namespace midterm.Services
{
    public class GroupService
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupService(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public async Task<List<Group>> GetGroups()
        {
            return await _groupsRepository.GetAll();
        }

        public async Task <Group> GetGroupToEdit(int? id)
        {
            return await _groupsRepository.editGroup(id);
        }



        public async Task AddAndSave(Group group)
        {
            _groupsRepository.Add(group);
            await _groupsRepository.Save();
        }
    }
}
