using System;
using System.Linq;
using Blog2.Data;
using Blog2.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog2
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new BlogDataContext())
      {
        // Create
        // var tag = new Tag { Name = "asd", Slug = "asdf"};
        // context.Tags.Add(tag);
        // context.SaveChanges();

        // Read
        // var tags = context.Tags
        //   .AsNoTracking()
        //   .ToList();
        
        // foreach (var tag in tags)
        // {
        //   Console.WriteLine(tag.Name);
        // }


        // Update
        // var tag = context.Tags.FirstOrDefault(t => t.Id == 7);
        // tag.Name = "asdasd";
        // tag.Slug = "asdfasdf";
        // context.Update(tag);
        // context.SaveChanges();


        // Delete
        // var tag = context.Tags.FirstOrDefault(t => t.Id == 7);
        // context.Remove(tag);
        // context.SaveChanges();

        
      }
    }
  }
}
