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
    }
}
