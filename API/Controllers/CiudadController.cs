using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class CiudadController : BaseController
{
    private readonly MyOwnProjectContext _context;

    public CiudadController(MyOwnProjectContext context)
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Ciudad>>> Get()
    {
        var ciudades = await _context.Ciudades.ToListAsync();
        return Ok(ciudades);
    }
}
