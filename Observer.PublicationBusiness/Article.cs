using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.PublicationBusiness
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ByLine { get; set; }
        public List<Author> Authors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleTitle">This is the title of the article. Try to keep it within 140 char</param>
        /// <param name="articleByLine">This is the by line. Try to keep it within 80 char</param>
        /// <param name="authors">This is the list of authors. Order matters. Do not sort.</param>
        public Article(string articleTitle, string articleByLine, List<Author> authors)
        {
            this.Id = Guid.NewGuid();
            this.Title = articleTitle;
            this.ByLine = articleByLine;
            this.Authors = authors;
        }
    }
}
