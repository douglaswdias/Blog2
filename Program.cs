using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Blog2.Data;
using Blog2.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog2
{
  class Program
  {
    static void Main(string[] args)
    {
      using var context = new BlogDataContext();

      // // Create User
      // context.Users.Add(new User
      // {
      //   Bio = "http",
      //   Email = "asidfh",
      //   Image = "http://",
      //   Name = "asidfh",
      //   PasswordHash = "asidfji",
      //   Slug = "asidf"
      // });
      // context.SaveChanges();

      // // Create Post with User
      // var user = context.Users.FirstOrDefault();
      // var post = new Post
      // {
      //   Author = user,
      //   Body = "kkkkkkkkkk",
      //   Category = new Category
      //   {
      //     Name = "jjjjjjjj",
      //     Slug = "hhhhhhhh",
      //   },
      //   CreateDate = DateTime.Now,
      //   Slug = "kkkkkkkkkkkk",
      //   Summary = "asdjkkkk",
      //   Title = "asdj"
      // };
      // context.Posts.Add(post);
      // context.SaveChanges();
    }
  }
}
