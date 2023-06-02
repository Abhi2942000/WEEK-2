// File: Program.cs

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (var dbContext = new BlogDbContext())
        {
            // Create a new blog
            var blog = new Blog
            {
                Title = "Sample Blog",
                Content = "This is a sample blog post."
            };

            // Add the blog to the database
            dbContext.Blogs.Add(blog);
            dbContext.SaveChanges();

            // Create some comments for the blog
            var comment1 = new Comment
            {
                Content = "Great blog post!",
                BlogId = blog.Id
            };

            var comment2 = new Comment
            {
                Content = "I enjoyed reading this.",
                BlogId = blog.Id
            };

            // Add the comments to the database
            dbContext.Comments.AddRange(comment1, comment2);
            dbContext.SaveChanges();

            // Retrieve the blog with its comments
            var retrievedBlog = dbContext.Blogs.Include(b => b.Comments).FirstOrDefault();

            // Display the blog and its comments
            Console.WriteLine($"Blog: {retrievedBlog.Title}");
            Console.WriteLine($"Content: {retrievedBlog.Content}");
            Console.WriteLine("Comments:");
            foreach (var comment in retrievedBlog.Comments)
            {
                Console.WriteLine(comment.Content);
            }
        }

        Console.ReadLine();
    }
}
