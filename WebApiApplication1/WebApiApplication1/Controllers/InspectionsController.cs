#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiApplication1.Data;
using WebApiApplication1.Domains;
using WebApiApplication1.Services;

namespace WebApiApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionsController : Controller
    {
        private readonly IInspectionService _inspectionService;

        public InspectionsController(IInspectionService inspectionService)
        {
            this._inspectionService = inspectionService;
        }

        // GET: api/Inspections
        [HttpGet]
        public async Task<IActionResult> GetInspections()
        {
            var inspectionList = _inspectionService.SearchInspection();
            return Json(inspectionList);
        }

        // GET: api/Inspections/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInspection(int id)
        {
            var inspection = _inspectionService.GetById(id);

            if (inspection == null)
            {
                return NotFound();
            }

            return Json(inspection);
        }

        //// PUT: api/Inspections/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutInspection(int id, Inspection inspection)
        //{
        //    if (id != inspection.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(inspection).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!InspectionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Inspections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inspection>> PostInspection(Inspection inspection)
        {
            //_context.Inspections.Add(inspection);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetInspection", new { id = inspection.Id }, inspection);
            if(inspection == null)
                return NotFound();
            _inspectionService.InsertInspection(inspection);

            return Json(inspection);
        }

        // DELETE: api/Inspections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspection(int id)
        {
            var inspection = _inspectionService.GetById(id);
            if (inspection == null)
            {
                return NotFound();
            }

            _inspectionService.DeleteInspection(inspection);

            return NoContent();
        }

        private bool InspectionExists(int id)
        {
            var inspection = _inspectionService.GetById(id);
            return inspection != null;
        }
    }
}
