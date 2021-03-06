using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.PublicationBusiness;

namespace Observer.PublicationBusiness.Tests
{
    /// <summary>This class contains parameterized unit tests for Author</summary>
    [TestClass]
    [PexClass(typeof(Author))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AuthorTest
    {

        /// <summary>Test stub for .ctor(String, String, String, String)</summary>
        [PexMethod]
        public Author ConstructorTest(
            string fullName,
            string shortName,
            string twitterHandle,
            string email
        )
        {
            Author target = new Author(fullName, shortName, twitterHandle, email);
            return target;
            // TODO: add assertions to method AuthorTest.ConstructorTest(String, String, String, String)
        }

        [TestMethod()]
        public void MockCreateAuthorTest()
        {
            string authorFullName = "John Herbers";
            string authorShortName = "John";
            string authorTwitterHandle = "nytimes";
            string authorEmail = "editorial@nytimes.com";
            Author author = new Author(authorFullName, authorShortName, authorTwitterHandle, authorEmail);
            Assert.AreEqual(author.Email, authorEmail);
            Assert.AreEqual(author.FullName, authorFullName);
            Assert.AreEqual(author.ShortName, authorShortName);
            Assert.AreEqual(author.TwitterHandle, authorTwitterHandle);
            Assert.AreEqual(author.Email, authorEmail);
        }
        [TestMethod()]
        public void ValidateEmail()
        {
            string email = "foo@bar";
            string authorFullName = "John Herbers";
            string authorShortName = "John";
            string authorTwitterHandle = "nytimes";
            string authorEmail = "editorial@nytimes.com";
            Author author = new Author(authorFullName, authorShortName, authorTwitterHandle, authorEmail);
            author.Email = email;
            Assert.AreEqual(author.Email, "spam.kushal@gmail.com");
        }
    }
}
