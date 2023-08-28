using Acme.BookStoreMVC.MultiLingualObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStoreMVC.Books
{
    public class AddBookTranslationDto : IObjectTranslation
    {
        [Required]
        public string Language { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
