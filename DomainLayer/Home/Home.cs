using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Utilities.Random;

namespace DomainLayer.Home
{
    public class Home:BaseEntity<int>
    {
        public Home()
        {
            this.IsShow = false;
            this.Date = DateTime.Now;
            this.Code = RandomNumber.GetRandomNumber().ToString();
            this.AdvisorId = 0;
            this.Title = "";
        }

        [Required]
        [MaxLength(10,ErrorMessage ="نباید از 10 حرف بیشتر باشد")]
        public string Code { get; set; }

        [Required(ErrorMessage ="نباید خالی باشد")]
        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string Address { get; set; }

        [Required(ErrorMessage = "کد پستی خالی باشد")]
        public string Postalcode { get; set; }
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string HomeMapImage { get; set; }

        [MaxLength(500, ErrorMessage = "نباید از 500 حرف بیشتر باشد")]
        public string ThreeDView { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Description { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public int BuildYear { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public int Bed { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        public int Bath { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public int Parking { get; set; }
        [Required(ErrorMessage = "نباید خالی باشد")]
        public int Bana { get; set; }

        public DateTime Date { get; set; }

        public Boolean IsShow { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نباید از 50 حرف بیشتر باشد")]
        public string Gpsx { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(50, ErrorMessage = "نباید از 50 حرف بیشتر باشد")]
        public string Gpsy { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(200, ErrorMessage = "نباید از 200 حرف بیشتر باشد")]
        public string OwnerName { get; set; }

        [MaxLength(100, ErrorMessage = "نباید از 100 حرف بیشتر باشد")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "نباید خالی باشد")]
        [MaxLength(100, ErrorMessage = "نباید از 100 حرف بیشتر باشد")]
        public string Mobile { get; set; }

        [MaxLength(1000, ErrorMessage = "نباید از 1000 حرف بیشتر باشد")]
        public string Image { get; set; }

        public Boolean IsPrivate { get; set; }

        public int? AdvisorId { get; set; }
        public int Hometype { get; set; }
        public int HometypeId { get; set; }


        public virtual ICollection<HomeGallery> HomeGalleries { get; set; }

        public virtual ICollection<Anbar> Anbar { get; set; }
        public virtual ICollection<Aparteman> Aparteman { get; set; }
        public virtual ICollection<Edari> Edari { get; set; }
        public virtual ICollection<Garden> Garden { get; set; }
        public virtual ICollection<GardenWithVila> GardenWithVila { get; set; }
        public virtual ICollection<HomewithGarden> HomewithGarden { get; set; }
        public virtual ICollection<Kolangi> Kolangi { get; set; }
        public virtual ICollection<Maghaze> Maghaze { get; set; }
        public virtual ICollection<Moshtghelat> Moshtghelat { get; set; }
        public virtual ICollection<Vila> Vila { get; set; }
        public virtual ICollection<Zamin> Zamin { get; set; }
        public virtual ICollection<Contract.Contract> Contracts { get; set; }
    }
}
