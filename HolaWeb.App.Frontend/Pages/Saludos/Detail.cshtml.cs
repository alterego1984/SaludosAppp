using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;

namespace HolaWeb.App.Frontend.Pages
{
    public class DetailModel : PageModel
    {
        private readonly IRepositorioSaludos repositorioSaludos;
       public Saludo Saludo {get;set;}

        public DetailModel(IRepositorioSaludos repositorioSaludos)
       {
            this.repositorioSaludos=repositorioSaludos;
       }

        public IActionResult OnGet(int saludoId)
        {
            Saludo=repositorioSaludos.GetSaludoPorId(saludoId);
            if(Saludo==null){
                return RedirectToPage("./Error");
            }else{
                return Page();
            }
        }
    }
}
