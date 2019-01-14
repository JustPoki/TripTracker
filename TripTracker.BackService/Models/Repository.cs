using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
	public class Repository
	{
		private List<Trip> MyTrips = new List<Trip>
		{
			new Trip
			{
				Id= 1,
				Name="MVP Summit",
				StartDate = new DateTime(2018,3,5),
				EndDate = new DateTime(2018,3,8)
			},
			new Trip
			{
				Id=2,
				Name="Dev Intersection Orlando",
				StartDate = new DateTime(2018,3,25),
				EndDate = new DateTime(2018,3,27)
			},
			new Trip
			{
				Id = 2,
				Name = "Build 2018",
				StartDate = new DateTime(2018,5,7),
				EndDate = new DateTime(2018,5,10)
			}
		};

		public List<Trip> Get()
		{
			return MyTrips;
		}

		public Trip Get(int id)
		{
			return MyTrips.First(t=> t.Id == id);
		}

		public void AddTrip(Trip newTrip)
		{
			MyTrips.Add(newTrip);
		}

		public void EditTrip(Trip tripToUpdate)
		{
			MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
			MyTrips.Add(tripToUpdate);
		}

		public void Remove(int id)
		{
			MyTrips.Remove(MyTrips.First(t => t.Id == id));
		}

	}
}
