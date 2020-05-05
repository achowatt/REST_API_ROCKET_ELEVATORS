using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using RocketElevatorApi.Models;
using System;

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

        // To get an intervention by id                               https://localhost:5001/api/intervention/2 
        // GET: api/intervention/(id)  
        [HttpGet("{id}")]
        public List<Intervention> FindInterventionByID(long ID)
        {
            var intervention = _context.Interventions.Where(t => t.id == ID).ToList();
            return intervention;
        }

        //GET: api/intervention/pending                               https://localhost:5001/api/intervention/pending
        //Returns all fields of all Service Request records that do not have a start date and are in "Pending" status.
        [HttpGet("pending")]
        public List<Intervention> getPending(string pending)
        {
            var intervention = _context.Interventions.Where(intervention => intervention.status == "pending" && intervention.start_date == null).ToList();
            return intervention;
        }

        // PUT: api/intervention/(id)                                  https://localhost:5001/api/intervention/2
        //Change value of any parameters
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

        // PUT: api/intervention/{id}/inProgress                      https://localhost:5001/api/intervention/2/inProgress 
        //Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).
        [HttpPut("{id}/inProgress")]
        public async Task<ActionResult<Intervention>> UpdateIntervention([FromRoute] long id)
        {
            var myIntervention = await this._context.Interventions.FindAsync(id);
            if (myIntervention == null)
            {
                return NotFound();
            }
            else
            {
                myIntervention.status = "pending";
                myIntervention.status = "InProgress";
                myIntervention.start_date = System.DateTime.Now;
            }
            this._context.Interventions.Update(myIntervention);
            await this._context.SaveChangesAsync();

            return Content("The status of the intenvention ID: " + myIntervention.id +
            " has been changed to: " + myIntervention.status + ". The start date is: "
             + myIntervention.start_date + ".");
        }

        // PUT: api/intervention/{id}/completed                  https://localhost:5001/api/intervention/2/completed
        //Change the status of the request for action to "Completed" and add an end date and time (Timestamp).
        [HttpPut("{id}/completed")]
        public async Task<ActionResult<Intervention>> InterventionCompleted([FromRoute] long id)
        {
            var myIntervention = await this._context.Interventions.FindAsync(id);
            if (myIntervention == null)
            {
                return NotFound();
            }
            else
            {
                myIntervention.result = "Successful";
                myIntervention.status = "Completed";
                myIntervention.end_date = System.DateTime.Now;
            }
            this._context.Interventions.Update(myIntervention);
            await this._context.SaveChangesAsync();

            return Content("The status of the intenvention ID: " + myIntervention.id +
            " has been changed to: " + myIntervention.status + ". The end date is: "
             + myIntervention.end_date + ".");
        }
    }
}