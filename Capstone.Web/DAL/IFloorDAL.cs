﻿using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capstone.Web.DAL
{
	public interface IFloorDAL
	{
		List<FloorModel> GetFloorsByHouseId(int houseId);
		bool CreateFloor(int floorNumber, int id);
		bool UpdateFloorPlan(int floorId, string json);
	}
}
