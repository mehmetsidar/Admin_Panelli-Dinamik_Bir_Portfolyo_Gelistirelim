namespace Admin_Panelli_Dinamik_Bir_Portfolyo_Gelistirelim.DAL.Entities
{
	public class Message
	{
        public int MessageId { get; set; }

		public string NameSurname { get; set; }

		public string Subject { get; set; }

		public string Email { get; set; }

		public DateTime MessageDetail { get; set; }
		public string IsRead { get; set; }
	}
}
