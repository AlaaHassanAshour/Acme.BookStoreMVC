using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStoreMVC.MultiLingualObjects
{
    public interface IMultiLingualObject<TTranslation>
       where TTranslation : class, IObjectTranslation
    {
        ICollection<TTranslation> Translations { get; set; }
    }
}
