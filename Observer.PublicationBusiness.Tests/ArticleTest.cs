// <copyright file="ArticleTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.PublicationBusiness;

namespace Observer.PublicationBusiness.Tests
{
    /// <summary>This class contains parameterized unit tests for Article</summary>
    [PexClass(typeof(Article))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ArticleTest
    {
        /// <summary>Test stub for .ctor(String, String, List`1&lt;Author&gt;)</summary>
        [PexMethod]
        public Article ConstructorTest(
            string articleTitle,
            string articleByLine,
            List<Author> authors
        )
        {
            Article target = new Article(articleTitle, articleByLine, authors);
            return target;
            // TODO: add assertions to method ArticleTest.ConstructorTest(String, String, List`1<Author>)
        }
    }
}
