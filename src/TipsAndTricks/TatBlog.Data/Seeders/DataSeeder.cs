using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Entities;
using TatBlog.Data.Contexts;

namespace TatBlog.Data.Seeders;

public class DataSeeder : IDataSeeder
{
    private readonly BlogDbContext _dbContext;

    public DataSeeder(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Initialize()
    {
        _dbContext.Database.EnsureCreated();

        if (_dbContext.Posts.Any()) return;

        var authors = AddAuthors();
        var categories = AddCategories();
        var tags = AddTags();
        var posts = AddPosts(authors, categories, tags);
    }

    private IList<Author> AddAuthors()
    {
        var authors = new List<Author>()
        {
            new()
            {
                FullName = "Jason Mouth",
                UrlSlug = "jason-mouth",
                Email = "jason@gmail.com",
                JoinedDate = new DateTime(2022, 10, 21)
            },
            new()
            {
                FullName = "Jessice Wonder",
                UrlSlug = "jessice-wonder",
                Email = "jessica665@motip.com",
                JoinedDate = new DateTime(2020, 4, 19)
            },
            new()
            {
                FullName = "Jane Doe",
                UrlSlug = "jane-doe",
                Email = "jane@gmail.com",
                JoinedDate = new DateTime(2022, 11, 15)
            },
            new()
            {
                FullName = "John Smith",
                UrlSlug = "john-smith",
                Email = "john@gmail.com",
                JoinedDate = new DateTime(2022, 12, 1)
            },
            new()
            {
                FullName = "Emma Lee",
                UrlSlug = "emma-lee",
                Email = "emma@gmail.com",
                JoinedDate = new DateTime(2023, 1, 7)
            },
            new()
            {
                FullName = "William Chen",
                UrlSlug = "william-chen",
                Email = "william@gmail.com",
                JoinedDate = new DateTime(2023, 2, 14)
            },
            new()
            {
                FullName = "Maria Rodriguez",
                UrlSlug = "maria-rodriguez",
                Email = "maria@gmail.com",
                JoinedDate = new DateTime(2023, 3, 1)
            },

        };

        _dbContext.Authors.AddRange(authors);
        _dbContext.SaveChanges();

        return authors;

    }

    private IList<Category> AddCategories()
    {
        var categories = new List<Category>()
        {
            new() {Name = ".NET Core", Description = ".NET Core", UrlSlug = ".NET Core", ShowOnMenu = true},
            new() {Name = "Architecture", Description = "Architecture", UrlSlug = "Architecture", ShowOnMenu = true},
            new() {Name = "Messaging", Description = "Messaging", UrlSlug = "Messaging", ShowOnMenu = true},
            new() {Name = "OOP", Description = "OOP", UrlSlug = "OOP", ShowOnMenu = true},
            new() {Name = "Design Parrterns", Description = "Design Parrterns", UrlSlug = "Design Parrterns", ShowOnMenu = true},
            new() {Name = "Data Structures", Description = "Data Structures", UrlSlug = "Data-Structures", ShowOnMenu = true},
            new() {Name = "Algorithms", Description = "Algorithms", UrlSlug = "Algorithms", ShowOnMenu = true},
            new() {Name = "Database Design", Description = "Database Design", UrlSlug = "Database-Design", ShowOnMenu = true},
            new() {Name = "Web Development", Description = "Web Development", UrlSlug = "Web-Development", ShowOnMenu = true},
            new() {Name = "Mobile Development", Description = "Mobile Development", UrlSlug = "Mobile-Development", ShowOnMenu = true},
            new() {Name = "Cloud Computing", Description = "Cloud Computing", UrlSlug = "Cloud-Computing", ShowOnMenu = true},
            new() {Name = "Security", Description = "Security", UrlSlug = "Security", ShowOnMenu = true},
            new() {Name = "Artificial Intelligence", Description = "Artificial Intelligence", UrlSlug = "Artificial-Intelligence", ShowOnMenu = true},
            new() {Name = "Machine Learning", Description = "Machine Learning", UrlSlug = "Machine-Learning", ShowOnMenu = true},
            new() {Name = "IoT", Description = "Internet of Things", UrlSlug = "IoT", ShowOnMenu = true}


        };

        _dbContext.AddRange(categories);
        _dbContext.SaveChanges();

        return categories;

    }

    private IList<Tag> AddTags()
    {
        var tags = new List<Tag>()
        {
            new() {Name = "Google", Description = "Google aoplication", UrlSlug = "Google"},
            new() {Name = "ASP.NET MVC", Description = "ASP.NET MVC", UrlSlug = "ASP.NET MVC"},
            new() {Name = "Razor Page", Description = "Razor Page", UrlSlug = "Razor Page"},
            new() {Name = "Blazor", Description = "Blazor", UrlSlug = "Blazor"},
            new() {Name = "Deep Learning", Description = "Deep Learning", UrlSlug = "Deep Learning"},
            new() {Name = "Netural Network", Description = "Netural Network", UrlSlug = "Netural Network"},
            new() {Name = "React", Description = "React library", UrlSlug = "React"},
            new() {Name = "Angular", Description = "Angular framework", UrlSlug = "Angular"},
            new() {Name = "Vue.js", Description = "Vue.js framework", UrlSlug = "Vue.js"},
            new() {Name = "Node.js", Description = "Node.js runtime", UrlSlug = "Node.js"},
            new() {Name = "Docker", Description = "Docker containerization", UrlSlug = "Docker"},
            new() {Name = "Kubernetes", Description = "Kubernetes orchestration", UrlSlug = "Kubernetes"},
            new() {Name = "GraphQL", Description = "GraphQL API", UrlSlug = "GraphQL"},
            new() {Name = "MongoDB", Description = "MongoDB database", UrlSlug = "MongoDB"},
            new() {Name = "Redis", Description = "Redis in-memory database", UrlSlug = "Redis"},
            new() {Name = "AWS", Description = "Amazon Web Services", UrlSlug = "AWS"}

        };

        _dbContext.AddRange(tags);
        _dbContext.SaveChanges();

        return tags;
    }

    private IList<Post> AddPosts(
        IList<Author> authors,
        IList<Category> categories,
        IList<Tag> tags)
    {
        var posts = new List<Post>()
        {
            new()
            {
                Title = "ASP.NET Core Diagnostic Scenarios",
                ShortDescription ="David and friends has a great repo",
                Description = "Here is a few great DON't and DO examples",
                Meta = "Davod and friends has a great respository filled",
                UrlSlug = "aspnet-core-diagnostic-scenarios",
                Published = true,
                PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                ModifiedDate = null,
                ViewCount = 10,
                Author = authors[0],
                Category = categories[0],
                Tags = new List<Tag>()
                {
                    tags[00]
                }
            },
            new()
        {
            Title = "Building a RESTful API with Node.js",
            ShortDescription = "Learn how to build a RESTful API with Node.js",
            Description = "In this tutorial, we'll walk through how to create a RESTful API with Node.js and Express",
            Meta = "Node.js, Express, RESTful API",
            UrlSlug = "building-restful-api-nodejs",
            Published = true,
            PostedDate = new DateTime(2022, 1, 15, 9, 0, 0),
            ModifiedDate = null,
            ViewCount = 50,
            Author = authors[1],
            Category = categories[1],
            Tags = new List<Tag>()
            {
                tags[2],
                tags[3]
            }
        },
        new()
        {
            Title = "Introduction to React Native",
            ShortDescription = "Get started with React Native",
            Description = "This article will introduce you to the basics of React Native and how to build a simple mobile app",
            Meta = "React Native, mobile app development",
            UrlSlug = "intro-to-react-native",
            Published = true,
            PostedDate = new DateTime(2022, 2, 1, 14, 30, 0),
            ModifiedDate = null,
            ViewCount = 100,
            Author = authors[2],
            Category = categories[3],
            Tags = new List<Tag>()
            {
                tags[0],
                tags[1],
                tags[2]
            }
        },
        new()
        {
            Title = "Getting Started with Docker",
            ShortDescription ="Learn the basics of Docker",
            Description = "In this tutorial, we'll cover the basics of Docker and how to use it to containerize your applications",
            Meta = "Docker, containerization",
            UrlSlug = "getting-started-docker",
            Published = true,
            PostedDate = new DateTime(2022, 2, 28, 11, 0, 0),
            ModifiedDate = null,
            ViewCount = 75,
            Author = authors[3],
            Category = categories[5],
            Tags = new List<Tag>()
            {
                tags[4],
                tags[5]
            }
        },
        new()
        {
            Title = "10 Tips for Better Code Quality",
            ShortDescription = "Improve your code quality with these tips",
            Description = "Here are 10 tips for writing better code and improving the quality of your software",
            Meta = "code quality, best practices",
            UrlSlug = "10-tips-better-code-quality",
            Published = true,
            PostedDate = new DateTime(2022, 3, 10, 16, 45, 0),
            ModifiedDate = null,
            ViewCount = 20,
            Author = authors[4],
            Category = categories[4],
            Tags = new List<Tag>()
            {
                tags[6],
                tags[7]
            }
        },
        };

        _dbContext.AddRange(posts);
        _dbContext.SaveChanges();

        return posts;
    }
}
