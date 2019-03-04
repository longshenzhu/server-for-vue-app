using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer.Domains;

namespace DataServer
{
    public class ProductTable
    {
        public static List<Product> AllProducts = new List<Product>()
        {
            new Product()
            {
                Id = new Guid("")
            },
            new Product()
            {
                Id = new Guid("")
            },
            new Product()
            {
                Id = new Guid("")
            },
            new Product()
            {
                Id = new Guid("")
            },
            new Product()
            {
                Id = new Guid("")
            }
        }; 
    }
    public class MyCartTable
    {
        
    }

    public class UserTable
    {
        public static List<Account> AllAccount = new List<Account>()
        {
            new Account()
            {
                Id = new Guid("b03aa59e-4265-45ee-9eef-5a41d83cca04"),
                LoginName = "super",
                NickName = "超级管理员",
                Description = "后门入口用户，拥有最高权限"
            },
            new Account()
            {
                Id = new Guid("64339454-4da9-43e3-9a6e-6f7697d22366"),
                LoginName = "admin",
                NickName = "管理员",
                Description = "管理员用户，最高管理员权限"
            },
            new Account()
            {
                Id = new Guid("bf733aed-b7d3-4424-8530-8993d94f0a1c"),
                LoginName = "test",
                NickName = "测试用户",
                Description = "登录可测试"
            },
            new Account()
            {
                Id = new Guid("fc1f672b-826f-476f-b00d-a9fb01100311"),
                LoginName = "account1",
                NickName = "普通用户1",
                Description = "普通用户1"
            },
            new Account()
            {
                Id = new Guid("5f4af12e-cbe4-428a-9abe-a9d600fd4c21"),
                LoginName = "account2",
                NickName = "普通用户2",
                Description = "普通用户2"
            },
        };
    }
}
