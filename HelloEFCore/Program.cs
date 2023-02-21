// See https://aka.ms/new-console-template for more information
using HelloEFCore;

Console.WriteLine("Hello, World!");

AppDb app = new AppDb();

Console.WriteLine(app.ConnectionString);