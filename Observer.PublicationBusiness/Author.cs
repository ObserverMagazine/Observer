using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.PublicationBusiness
{
    public class Author
    {
        private string _email;
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string TwitterHandle { get; set; }
        public string Email {
            get { return _email; }
            set
            {
                var foo = new System.ComponentModel.DataAnnotations.EmailAddressAttribute();
                if (foo.IsValid(value))
                {
                    _email = value;
                }
                else
                {
                    _email = "";
                }
            }
        }
        public Author(string fullName, string shortName, string twitterHandle, string email)
        {
            this.Id = Guid.NewGuid();
            this.FullName = fullName;
            this.ShortName = shortName;
            this.TwitterHandle = twitterHandle;
            this.Email = email;
        }

    }
}
