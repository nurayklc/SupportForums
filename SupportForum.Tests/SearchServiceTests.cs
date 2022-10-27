﻿using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SupportForum.Data;
using SupportForum.Data.Models;
using SupportForum.Service;
using System;
using System.Linq;

namespace SupportForum.Tests
{
    [TestFixture]
    public class Post_Service_Should
    {
        [Test]
        public void Return_Filtered_Results_Corresponding_To_Query()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "Search_Database").Options;

            //Arrange 
            using ( var ctx = new ApplicationDbContext(options))
            {
                ctx.Forums.Add(new Forum
                {
                    Id = 19
                });
                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 2121,
                    Content = "Coffee",
                    Title = "First Post"
                });
                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = -5656,
                    Content = "Some Content",
                    Title = "First Post"
                });
                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 124,
                    Content = "Coffee",
                    Title = "Tea Post"
                });

                ctx.SaveChanges();
            }
            
            //Act
            using(var ctx = new ApplicationDbContext(options))   
            {
                var postService = new PostService(ctx);
                var result = postService.GetFilteredPosts("Coffee");
                var postCount = result.Count();

                //Assert
                Assert.AreEqual(2, postCount);
            }
        }
    }
}