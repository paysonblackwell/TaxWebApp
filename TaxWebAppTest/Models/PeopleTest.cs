using TaxWebApp.Models;
using System;
using Xunit;

namespace TaxWebAppTest
{
    public class PeopleTest
    {
        [Fact]
        public void Create()
        {
            var person = new Person()
            {
                Name = "Test",
                New = "x",
                In = "11/17/1018",
                Preparer = "Dave"

            };
            ViewData["test"] = "test";
            Assert.NotEmpty(person.Name);
            Assert.NotEmpty(person.New);
            Assert.NotEmpty(person.In);
            Assert.NotEmpty(person.Preparer);


            Assert.Null(person.Notes);
                                 
        }
    }
}
