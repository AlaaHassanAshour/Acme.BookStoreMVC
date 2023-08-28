using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.BookStoreMVC.Authors;
public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(BookStoreMVCDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}