using Domain.Interface;
using FatoresPrimos.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FatoresPrimosTest
{
    public class FatoresPrimosControllerTest
    {
        private readonly FatoresPrimosController _controller;
        private readonly IAlgoritmoService _service;

        public FatoresPrimosControllerTest()
        {
            _service = new AlgoritmoServiceTest();
            _controller = new FatoresPrimosController(_service);
        }

        [Fact]
        public void Verifica_Numero_Divisores_NumerosPrimos()
        {
            // Act
            var okResult = _controller.Calcular(90) as OkObjectResult;
            // Assert
            var items = Assert.IsType<ObjDividendos>(okResult.Value);
            Assert.Equal(12, items.lstDivisores.Count);
            Assert.Equal(3, items.lstNumerosPrimos.Count);
        }
    }
}
