using Acme.BookStoreMVC.Authors;
using Acme.BookStoreMVC.Books;
using AutoMapper;

namespace Acme.BookStoreMVC;

public class BookStoreMVCApplicationAutoMapperProfile : Profile
{
    public BookStoreMVCApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();

    }
}
