using MembersOnly.Models;
using Microsoft.AspNetCore.HttpOverrides;
using System;
using System.Linq;

namespace MembersOnly.Data
{
    public static class PostInitializer
    {
        public static void Initialize(PostContext context)
        {
            context.Database.EnsureCreated();

            // Look for any posts.
            if (context.Posts.Any())
            {
                return;
            }

            var posts = new Post[]
            {
                new Post{Title="First Post", TextContent="This is my first post", Author="Mokeaveny"},
                new Post{Title="Second Post", TextContent="This is my second post", Author="Mokeavo"},
                new Post{Title="Game of Thrones", TextContent="Game of thrones is the best tv show of all time", Author="GameOfThronesLover"}
            };
            foreach (Post p in posts)
            {
                context.Posts.Add(p);
            }
            context.SaveChanges();
        }
    }
}
