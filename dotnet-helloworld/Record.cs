using System.ComponentModel.DataAnnotations;
namespace ConsoleApplication
{
    public class Record
    {
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string Type { get; set; }
    }
}