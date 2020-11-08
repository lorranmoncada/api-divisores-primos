using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FatoresPrimos.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class FatoresPrimosController : Controller
    {
        public readonly IAlgoritmoService _IAlgoritmoService;

        public FatoresPrimosController(IAlgoritmoService IAlgoritmoService)
        {
           
            _IAlgoritmoService = IAlgoritmoService;
        }

        [HttpGet("{value}")]
        public IActionResult Calcular(int value)
        {

            if (value > 0)
            {
                ObjDividendos _objDividendos = new ObjDividendos();
                return Ok(_IAlgoritmoService.AllValues(_objDividendos, value));
            }
            throw new ArgumentException(
            $"Valor Precisa ser maio do que {value}");
        }
    }
}
