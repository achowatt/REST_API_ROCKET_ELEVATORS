using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using RocketElevatorApi.Models;

namespace RocketElevatorApi.Controllers
{
    [Route("api/intervention")]
    [ApiController]
    public class InterventionController : ControllerBase
    {
        private readonly RocketElevatorContext _context;
        public InterventionController(RocketElevatorContext context)
        {
            _context = context;
        }

        // To see all the interventions                            https://localhost:5001/api/intervention/all
        // GET: api/intervention/all
        [HttpGet("all")]
        public IEnumerable<Intervention> GetIntervention()
        {
            return _context.Interventions;
        }

        // To get an intervention by id                              https://localhost:5001/api/internvetion/2 
        // GET: api/battery/(id)  
        [HttpGet("{id}")]
        public List<Intervention> FindInterventionByID(long ID)
        {
            var intervention = _context.Interventions.Where(t => t.id == ID).ToList();
            return intervention;
        }

        //GET: api/intervention/pending                         https://localhost:5001/api/intervention/pending
        //Returns all fields of all Service Request records that do not have a start date and are in "Pending" status.
        [HttpGet("{pending}")]
        public List<Intervention> getPending(string pending)
        {
            var intervention = _context.Interventions.Where(intervention => intervention.status == "pending" && intervention.start_date == null).ToList();
            return intervention;
        }

        // PUT: api/intervention/(id)                                 https://localhost:5001/api/intervention/2
        //Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).
        //Change the status of the request for action to "Completed" and add an end date and time (Timestamp).

        [HttpPut("{id}")]
        public async Task<ActionResult<Intervention>> putIntervention(long ID, Intervention intervention)
        {
            if (ID != intervention.id)
            {
                return null;
            }
            _context.Entry(intervention).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (ID != intervention.id)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Content("The status of the intenvention ID: " + intervention.id +
            " has been changed to: " + intervention.status + ". The start date is: "
             + intervention.start_date + " and the end date is: " + intervention.end_date);
        }
    }
}