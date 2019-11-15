using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using midterm.Services;
using Moq;
using Xunit;
namespace midterm.Models
{
    public class GroupsServiceTests
    {

        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<IGroupsRepository>();
            var groupService = new GroupService(fakeRepository);

            var group = new Group() { group_name = "test group" };
            await groupService.AddAndSave(group);
        }
        [Fact]
        public async Task NullNameAddTest()
        {
            var fakeRepository = Mock.Of<IGroupsRepository>();
            var groupService = new GroupService(fakeRepository);
            String name = "";
            Assert.NotNull(name);
            var group = new Group() { group_name = name };
            await groupService.AddAndSave(group);
        }

        [Fact]
        public async Task GetGroupsTest()
        {
            var groups = new List<Group>
            {
                new Group() { group_name = "test group 1" },
                new Group() { group_name = "test group 2" },
            };
            var fakeRepositoryMock = new Mock<IGroupsRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(groups);


            var groupService = new GroupService(fakeRepositoryMock.Object);

            var resultGroups = await groupService.GetGroups();

            Assert.Collection(resultGroups, group =>
            {
                Assert.Equal("test group 1", group.group_name);
            },
            group =>
            {
                Assert.Equal("test group 2", group.group_name);
            });
        }




        [Fact]
        public async Task editGroupTest()
        {

            var groups = new Group() { GroupID = 1 };

            var fakeRepository = Mock.Of<IGroupsRepository>();
            var groupService = new GroupService(fakeRepository);

            var resultGroups = await groupService.GetGroupToEdit(1);
            
                Assert.Equal(resultGroups.GroupID, groups.GroupID);
          

            
            
        }

    }
}
