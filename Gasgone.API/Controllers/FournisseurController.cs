using Gasgone.ORM.Business;
using Gasgone.ORM.Data;
using Gasgone.ORM.Service;
using Microsoft.AspNetCore.Mvc;


namespace Gasgone.API.Controllers
{
    [ApiController]
    public class FournisseurController : ControllerBase
    {
        private readonly DataContext _bdd;
        public FournisseurController(DataContext bdd)
        {
            _bdd = bdd;
        }



        [HttpGet("/Fournisseurs")]
        public IActionResult Get()
        {
            return Ok(new ServiceFournisseur(_bdd).Get());
        }

        [HttpPost("/AddFournisseur/")]
        public IActionResult Add(Fournisseur model)
        {
            return Ok(new ServiceFournisseur(_bdd).Add(model));
        }
    }
}
