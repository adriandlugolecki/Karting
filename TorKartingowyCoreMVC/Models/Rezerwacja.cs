﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TorKartingowyCoreMVC.Models
{
    public class Rezerwacja
    {
        [Key]
        public int Numer { get; set; }

        [Required(ErrorMessage = "Wybierz termin")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Wybierz godzinę")]
        public string Godzina { get; set; }

        [Required(ErrorMessage = "Wybierz długość trwania rezerwacji"), DisplayName("Czas jazdy")]
        [Range(1, 10, ErrorMessage = "Dopuszczalna liczba godzin to 1-10")]
        public int Czas { get; set; }

        public bool DodatkoweSzkolenia { get; set; } = false;

        [DisplayName("Zaliczka zamiast całej kwoty")]
        public bool Zaliczka { get; set; } = false;

        [Required(ErrorMessage = "Podaj liczbę osób"), DisplayName("Liczba osób")]
        [Range(1, 20, ErrorMessage = "Dopuszczalna liczba osób to 1-20")]
		public int LiczbaOsob { get; set; }

        public string Gokarty { get; set; } = "";

        //Navigation Properties
        [Required]
        [ForeignKey("Klient")]
        public int KlientNumer { get; set; }
        public virtual Klient? Klient { get; set; }

        [Required(ErrorMessage = "Wybierz tor")]
        [ForeignKey("Tor")]
        public int TorId { get; set; }
        public virtual Tor? Tor { get; set; }

        public int? PracownikId { get; set; }
        public virtual Pracownik? Pracownik { get; set; } = null;

        [Required]
        [ForeignKey("Platnosc")]
        public int PlatnoscNumer { get; set; }
        public virtual Platnosc? Platnosc { get; set; }
    }
}
