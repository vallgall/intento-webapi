using intento1.Models;
using intento1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intento1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        public BeerService _beerService;

        public BeerController(BeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public ActionResult<List<Beer>> Get()
        {
            return _beerService.Get();
        }

        [HttpPost]
        public ActionResult<Beer> Create(Beer beer)
        {
            _beerService.Create(beer);
            return Ok(beer);
        }

        [HttpPut]
        public ActionResult Update(Beer beer)
        {
            _beerService.Update(beer.Id, beer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _beerService.Delete(id);
            return Ok();
        }
    }
}
