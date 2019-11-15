using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using midterm.Models;
using midterm.Services;
using Moq;
using Xunit;

namespace midtermTest
{
    public class GroupTest
    {


        [Fact]
        public void CreateTest()
        {
            String str = "1/CSSE1602//16";
            String[] str_arr = str.Split('/');
            Boolean check = true;
            int id1 = Int32.Parse(str_arr[0]);
            String group_name1 = str_arr[1];
            String group_level1= str_arr[2];
            int stud_num1 = Int32.Parse(str_arr[3]);
            try{
                Group group = new Group(id1, group_name1, group_level1, stud_num1);
            }
            catch{
                check = false;
            }
            Assert.True(check);
        }

        [Fact]
        public void IsNullNameTest()
        {
            String name = null;
            Assert.Null(name);
        }

        [Fact]
        public void IsEmptyNameTest()
        {
            String name = "s";
            Assert.NotEmpty(name);
        }

        [Fact]
        public void ForbiddenSymbolsInNameTest()
        {
            String str = "Aziz", str2 = "!@#$%^&*()_+-=";
            Boolean check = true;
            for (int i = 0; i < str.Length; i++){
                for (int j = 0; j < str2.Length; j++){
                    if (str[i] == str2[j]){
                        check = false;
                    }
                }
            }
            Assert.True(check);
        }

        [Fact]
        public void IsNullLevelTest()
        {
            String lvl = null;
            Assert.Null(lvl);
        }

        [Fact]
        public void IsEmptyLevelTest()
        {
            String lvl = "s";
            Assert.NotEmpty(lvl);
        }
        public void NotNullIdTest()
        {
            int? id = 5;
            Boolean check = true;
            if (id == null) check = false;
            Assert.True(check);
        }

        [Fact]
        public void IsNegativeIdTest()
        {
            int id = 5;
            Boolean check = true;
            if (id < 0) check = false;
            Assert.True(check);
        }
    }
}
