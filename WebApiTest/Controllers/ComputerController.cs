﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using WebApiTest.Application.Services;
using WebApiTest.Application.Commands;

namespace WebApiTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService computerService;
        private readonly IMediator mediator;
        public ComputerController(
            IComputerService computerService,
            IMediator mediator
            )
        {
            this.computerService = computerService;
            this.mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok(await computerService.GetAll());
        }

        [HttpPut()]
        public async Task<IActionResult> Save([FromBody]SaveComputerCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
