using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;    

namespace API.Controllers;


public class PaisController : BaseController
{
    private readonly MyOwnProjectContext _context;

    public PaisController (MyOwnProjectContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    
    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var paises = await _context.Paises.ToListAsync();
        return Ok(paises);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Get(int id)
    {
        var pais = await _context.Paises.FindAsync(id);
        return Ok(pais);
    }

}
