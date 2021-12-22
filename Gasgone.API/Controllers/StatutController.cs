using Gasgone.ORM.Business;
using Gasgone.ORM.Data;
using Gasgone.ORM.Service;
using Microsoft.AspNetCore.Mvc;


namespace Gasgone.API.Controllers
{
    [ApiController]
    public class StatutController : ControllerBase
    {
        private readonly DataContext _bdd;
        public StatutController(DataContext bdd)
        {
            _bdd = bdd;
        }



        [HttpGet("/Statuts")]
        public IActionResult Get()
        {
            return Ok(new ServiceStatut(_bdd).Get());
        }

        [HttpPost("/AddStatut/")]
        public IActionResult Add(Statut model)
        {
            return Ok(new ServiceStatut(_bdd).Add(model));
        }
    }
}
