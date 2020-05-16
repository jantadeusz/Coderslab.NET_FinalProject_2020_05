using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        [Required]
        public string Longitude { get; set; } //długość geograficzna 0-360
        [Required]
        public string Latitude { get; set; } //szerokość geograficzna od -90 do 90
        [Column(TypeName = "decimal(18,2)")]
        public decimal Elevation { get; set; }
        //gdy ConsumerId nie jest string ustawione to wali bledem migracji
        public string ConsumerId { get; set; }
        //[ForeignKey("Id")]
        public ConsumerModel Consumer { get; set; }
        // zamysł jest taki żeby ta właściwość wskazywała 
        // na obiekt klasy implementujacej interfejs ILocaton czyli albo producent albo konsument



    }
}