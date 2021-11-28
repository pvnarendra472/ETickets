using ETickets.Data;
using ETickets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ETickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "URL is Required")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "StartDate is Required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "EndDate is Required")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "MovieCategory is Required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Required(ErrorMessage = "Actor is Required")]
        public List<int> ActorsIds { get; set; }

        [Required(ErrorMessage = "Cinema is Required")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Producer is Required")]
        public int ProducerId { get; set; }

        
    }
}
