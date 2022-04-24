using System;

namespace EFCoreSQLiteSample.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
