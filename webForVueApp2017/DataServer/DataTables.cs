using DataServer.Domains;
using System;
using System.Collections.Generic;

namespace DataServer
{
    public class ProductTable
    {
        public static List<Product> AllProducts = new List<Product>()
        {
            new Product()
            {
                Id = new Guid("553aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "yonex羽毛球拍双刃10",
                Prize = 1400,
                Description = "yonex羽毛球拍双刃",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("663aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "林丹战靴三代",
                Prize = 960,
                Description = "林丹战靴三代",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("783aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "李宗伟大英赛球服",
                Prize = 450,
                Description = "李宗伟大英赛球服",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("963aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "dell笔记本灵越14",
                Prize = 5500,
                Description = "笔记本还不错",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("df3aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "128G 苹果7",
                Prize = 6188,
                Description = "手机越来越贵了",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("df3aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "狼蛛机械键盘",
                Prize = 128,
                Description = "我有两个机械键盘",
                ImageUrls = new List<string>()
            },
            new Product()
            {
                Id = new Guid("df3aa59e-4265-45ee-9eef-5a41d83cca04"),
                Name = "Scofield 服装",
                Prize = 1600,
                Description = "很喜欢这个牌子的衣服",
                ImageUrls = new List<string>()
            }
        };
    }
    public class MyCartTable
    {
        public static List<Guid> AllProducts = new List<Guid>()
        {
            new Guid("553aa59e-4265-45ee-9eef-5a41d83cca04")
        };
    }

    public class UserTable
    {
        public static List<Account> AllAccount = new List<Account>()
        {
            new Account()
            {
                Id = new Guid("b03aa59e-4265-45ee-9eef-5a41d83cca04"),
                LoginName = "super",
                Password = "123456",
                NickName = "超级管理员",
                Description = "后门入口用户，拥有最高权限"
            },
            new Account()
            {
                Id = new Guid("64339454-4da9-43e3-9a6e-6f7697d22366"),
                LoginName = "admin",
                Password = "123456",
                NickName = "管理员",
                Description = "管理员用户，最高管理员权限"
            },
            new Account()
            {
                Id = new Guid("bf733aed-b7d3-4424-8530-8993d94f0a1c"),
                LoginName = "test",
                Password = "123456",
                NickName = "测试用户",
                Description = "登录可测试"
            },
            new Account()
            {
                Id = new Guid("fc1f672b-826f-476f-b00d-a9fb01100311"),
                LoginName = "account1",
                Password = "123456",
                NickName = "普通用户1",
                Description = "普通用户1"
            },
            new Account()
            {
                Id = new Guid("5f4af12e-cbe4-428a-9abe-a9d600fd4c21"),
                LoginName = "account2",
                Password = "123456",
                NickName = "普通用户2",
                Description = "普通用户2"
            },
        };
    }

    public class OrderTable
    {
        public static List<Order> AllOrders = new List<Order>();
    }
}
