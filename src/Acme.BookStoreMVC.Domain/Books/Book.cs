using Acme.BookStoreMVC.MultiLingualObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStoreMVC.Books
{
    public class Book : AuditedAggregateRoot<Guid>, IMultiLingualObject<BookTranslation>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
        public Guid AuthorId { get; set; }

        public ICollection<BookTranslation> Translations { get; set; }
    }
}
