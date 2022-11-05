using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Data.DAL;
using BlazorApp1.Data.Models;
using NuGet.Protocol;

namespace BlazorApp1.Data.Controllers
{
    [Route("api/tenants")]
    [ApiController]
    public class TenantsController : Controller
    {
        private readonly DataContext _context;

        public TenantsController(DataContext context)
        {
            _context = context;
        }

        //GET Tenants

        [HttpGet]
        public async Task<ActionResult> GetTenants()
        {
            if (_context.Tenants == null)
                return NotFound();

            var tenants = await _context.Tenants.ToListAsync();

            return Ok(tenants.ToJson());
        }

        [HttpPost]
        public async Task<ActionResult<JsonResult>> CreateTenant(TenantDto model)
        {
            if (_context.Tenants == null)
                return NotFound();

            var tenant = new Tenant()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Address = model.Address,
                DateOfBirth = model.DateOfBirth
            };

            try
            {
                await _context.Tenants.AddAsync(tenant);
            }
            catch
            {
                return BadRequest(model.ToJson());
            }

            return Ok(model.ToJson());
        }
    }
}
