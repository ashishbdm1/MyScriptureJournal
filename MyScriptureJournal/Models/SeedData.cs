using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Title = "Book of Nephi",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Book = "1stNephi",
                        Chapter = 5,
                        Verses = 1-6,
                        Note = "It tought my heart."
                    },

                    new Scripture
                    {
                        Title = "Book of Alma",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Book = "2nd Nephi",
                        Chapter = 5,
                        Verses = 1 - 6,
                        Note = "I could liken the scripture"
                    },

                    new Scripture
                    {
                        Title = "Misiah",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Book = "3rd Nephi",
                        Chapter = 5,
                        Verses = 1 - 6,
                        Note = "Really Inspiring."
                    },

                    new Scripture
                    {
                        Title = "Book of Nephi",
                        DateAdded = DateTime.Parse("1989-2-12"),
                        Book = "4th Nephi",
                        Chapter = 5,
                        Verses = 1 - 6,
                        Note = "I could liken the scripture"
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
