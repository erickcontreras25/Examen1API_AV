using System;
using System.Threading.Tasks;
using Calculadora.API.Data;
using Calculadora.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : Controller
    {
        private readonly DataContext _context;

        public CalculadoraController(DataContext contex)
        {
            _context = contex;
        }

        [HttpGet("sumar")]
        public IActionResult Sumar(decimal n1, decimal n2)
        {
            decimal resultado = _context.Sumar(n1, n2);
            return Ok(resultado);
        }

        [HttpGet("restar")]
        public IActionResult Restar(decimal n1, decimal n2)
        {
            decimal resultado = _context.Restar(n1, n2);
            return Ok(resultado);
        }

        [HttpGet("multiplicar")]
        public IActionResult Multiplicar(decimal n1, decimal n2)
        {
            decimal resultado = _context.Multiplicar(n1, n2);
            return Ok(resultado);
        }

        [HttpGet("dividir")]
        public IActionResult Dividir( decimal n1, decimal n2)
        {
            decimal resultado = 0;
            try
            {
                resultado = _context.Dividir(n1, n2);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(resultado);
        }


        [HttpGet("exponencial")]
        public IActionResult Exponencial( double n1)
        {
            double resultado = _context.Exponencial(n1);
            return Ok(resultado);
        }

        [HttpGet("raizCuadrada")]
        public IActionResult RaizCuadrada( double n1)
        {
            double resultado = _context.RaizCuadrada(n1);
            return Ok(resultado);
        }
        
        
    }
}