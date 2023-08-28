using Acme.BookStoreMVC.Authors;
using Acme.BookStoreMVC.Books;
using Acme.BookStoreMVC.Web.Pages.Books;
using AutoMapper;

namespace Acme.BookStoreMVC.Web;

public class BookStoreMVCWebAutoMapperProfile : Profile
{
    public BookStoreMVCWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
               CreateAuthorDto>();
        CreateMap<AddTranslationModal.BookTranslationViewModel, AddBookTranslationDto>();
    }
}
