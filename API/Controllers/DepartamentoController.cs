using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class DepartamentoController : BaseController
{
    private readonly MyOwnProjectContext _context;
    public DepartamentoController(MyOwnProjectContext context)
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Departamento>>> Get()
    {
        var departamentos = await _context.Departamentos.ToListAsync();
        return Ok(departamentos);
    }
}
