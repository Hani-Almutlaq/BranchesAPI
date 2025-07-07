using BranchesAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BranchesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly DataContext _context;

        public BranchesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> GetAvailability(int branchId, DateTime dateTime)
        {
            // Extract the day name from DateTime parameter
            var day = dateTime.DayOfWeek.ToString();

            // Retrieve the value (opening period e.g. 8:00 - 17:00) from the database
            var query = $"SELECT {day} AS [Value] FROM Schedules WHERE BranchId = {branchId}";

            if (query == null)
                return NotFound();

            // Store the opening period
            var openPeriod = await _context.Database.SqlQueryRaw<string>(query).FirstOrDefaultAsync();

            // If the opening period equals null then the branch is NOT open
            if (openPeriod == null)
                return false;

            // Split the opening period to create separate time spans for the comparison
            var openPeriodDivided = openPeriod.Split(" - ");
            TimeSpan start = TimeSpan.Parse(openPeriodDivided[0]);
            TimeSpan end = TimeSpan.Parse(openPeriodDivided[1]);

            // Extract the time from DateTime parameter
            TimeSpan time = dateTime.TimeOfDay;

            // Compare if time within opening period
            bool isOpen = time >= start && time <= end;

            return isOpen;
        }
    }
}
