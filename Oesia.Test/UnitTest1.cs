using NUnit.Framework;
using Oesia.Infrastructure.DTOs;
using Oesia.Service.Interfaces;
using System.Threading.Tasks;

namespace Oesia.Test
{
    public class UnitTest1
    {
        private IAuthorService _authorService;
        [SetUp]
        public void Setup()
        {
            var serviceProvider = Startup.ServiceProvider;
            if (serviceProvider != null)
            {
                //_authorService = serviceProvider.GetService<IAuthorService>;
            }
        }

        [Test]
        public async Task AuthorServiceAdd_TestAsync()
        {
            var author = new AuthorDTO
            {
                Name = "Juan",
                LastName = "Perez",
                IdGender = 1,
                NumberBooks = 3
            };

            var actualResult = await _authorService.CreateAuthor(author);
            var expectedResult = true;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
