using Microsoft.EntityFrameworkCore; // Veri erişimi için Entity Framework Core kütüphanesini kullanma
using Admin_Panelli_Dinamik_Bir_Portfolyo_Gelistirelim.DAL.Entities; // Varlık sınıflarının tanımlandığı ad alanını kullanma

namespace Admin_Panelli_Dinamik_Bir_Portfolyo_Gelistirelim.DAL.Context // Bağlam için ad alanını tanımlama
{
	public class MyPortFolioContext : DbContext // Veritabanı ile etkileşim için DbContext sınıfını tanımlama
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Veritabanı bağlantısını ayarlamak için OnConfiguring yöntemini geçersiz kılma
		{
			// Bağlamı, bağlantı dizesi ile bir SQL Server veritabanı kullanacak şekilde yapılandırma
			optionsBuilder.UseSqlServer("Server=DESKTOP-UFOHFCO\\SQLEXPRESS;initial Catalog=MyPortFolioDb;integrated Security=true;");
		}

		// Veritabanındaki tabloları temsil eden DbSet özellikleri
		public DbSet<About> Abouts { get; set; } // Veritabanındaki "Abouts" tablosunu temsil eder
		public DbSet<Contact> Contact { get; set; } // Veritabanındaki "Contact" tablosunu temsil eder
		public DbSet<Experience> Experiences { get; set; } // Veritabanındaki "Experiences" tablosunu temsil eder
		public DbSet<Feature> Feature { get; set; } // Veritabanındaki "Feature" tablosunu temsil eder
		public DbSet<Message> Message { get; set; } // Veritabanındaki "Message" tablosunu temsil eder
		public DbSet<Portfolio> Portfolio { get; set; } // Veritabanındaki "Portfolio" tablosunu temsil eder
		public DbSet<ScoialMedia> ScoialMedia { get; set; } // Veritabanındaki "ScoialMedia" tablosunu temsil eder
		public DbSet<Skill> Skill { get; set; } // Veritabanındaki "Skill" tablosunu temsil eder
		public DbSet<Testimonial> Testimonial { get; set; } // Veritabanındaki "Testimonial" tablosunu temsil eder
	}
}
