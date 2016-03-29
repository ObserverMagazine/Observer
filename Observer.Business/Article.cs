using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Business
{
    public class Article
    {
        public Guid Id { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleByLine { get; set; }
        public List<Author> Authors { get; set; }
    }
}
