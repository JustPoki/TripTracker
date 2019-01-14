using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
	[Route("api/[controller]")]
	public class TripsController : Controller
	{

		public TripsController(Models.Repository repository)
		{
			_repository = repository;
		}

		private Models.Repository _repository;

		// GET api/Trips
		[HttpGet]
		public IEnumerable<Models.Trip> Get()
		{
			return _repository.Get();
		}

		// GET api/Trips/5
		[HttpGet("{id}")]
		public Trip Get(int id)
		{
			return _repository.Get(id);
		}

		// POST api/Trips
		[HttpPost]
		public void Post([FromBody]Trip value)
		{
			_repository.AddTrip(value);
		}

		// PUT api/Trips/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]Trip value)
		{
			_repository.AddTrip(value);
		}

		// DELETE api/Trips/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_repository.Remove(id);
		}
	}
}
