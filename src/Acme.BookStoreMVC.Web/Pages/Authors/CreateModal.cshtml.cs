using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Acme.BookStoreMVC.Authors;

namespace Acme.BookStoreMVC.Web.Pages.Authors
{
    public class CreateModalModel : BookStoreMVCPageModel
    {
        [BindProperty]
        public CreateAuthorViewModel Author { get; set; }

        private readonly IAuthorAppService _authorAppService;

        public CreateModalModel(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }

        public void OnGet()
        {
            Author = new CreateAuthorViewModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateAuthorViewModel, CreateAuthorDto>(Author);
            await _authorAppService.CreateAsync(dto);
            return NoContent();
        }

        public class CreateAuthorViewModel
        {
            [Required]
            [StringLength(AuthorConsts.MaxNameLength)]
            public string Name { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }

            [TextArea]
            public string ShortBio { get; set; }
        }
    }
    }