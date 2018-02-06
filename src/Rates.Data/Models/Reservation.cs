﻿namespace Rates.Data.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public string ReservationUuid { get; set; }
		public int RoomRateId { get; set; }
		public decimal TotalAmount { get; set; }
	}
}
