using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RVezyTest.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RVezyTest.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingsController : ControllerBase
    {

        private readonly ILogger<ListingsController> _logger;
        private IEnumerable<Listing> _listings = new List<Listing>();

        public ListingsController(ILogger<ListingsController> logger)
        {
            _logger = logger;
            _listings = ReadListings();
        }

        private IEnumerable<Listing> ReadListings()
        {
            using StreamReader inputReader = new StreamReader("./listings.csv");
            using CsvReader csvReader = new CsvReader(inputReader, CultureInfo.InvariantCulture);
            {
                var records = csvReader.GetRecords<Listing>().ToList();
                return records;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Listing> GetListing(int id)
        {
            try
            {
                var listing = _listings.First(l => l.id == id);
                return Ok(listing);
            }
            catch (InvalidOperationException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Listing>> GetPaginatedListings([FromQuery] int pageSize = 10, [FromQuery] int page = 1)
        {
            return Ok(_listings.Skip((page - 1) * pageSize).Take(pageSize));
        }

        [HttpGet("/{type}")]
        public ActionResult<IEnumerable<Listing>> GetPaginatedListings([FromRoute] string type, [FromQuery] int pageSize = 10, [FromQuery] int page = 1)
        {
            return Ok(_listings
                .Where(l => l.property_type == type)
                .Skip((page - 1) * pageSize).Take(pageSize));
        }
    }
}
