using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter the Title of the Book")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter the Author of the Book")]
        public string Author { get; set; }

        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }

        public string Category { get; set; }
        [Required(ErrorMessage = "Please select the Language of the Book")]
        public int LanguageId { get; set; }

        public string Language { get; set; }

        [Display(Name = "Total Pages of the Book")]
        [Required(ErrorMessage = "Please Enter the Total Pages of the Book")]
        public int? TotalPages { get; set; }

        [Display(Name = "Cover photo of the book")]
        [Required(ErrorMessage = "Please upload the cover photo of the book")]
        public IFormFile CoverPhoto { get; set; }

        [Display(Name = "Gallery photos of the book")]
        [Required(ErrorMessage = "Please upload the gallery photos of the book")]
        public IFormFileCollection GalleryPhotos { get; set; }

        public string CoverImageUrl { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "PDF of the book")]
        [Required(ErrorMessage = "Please upload the PDF of the book")]
        public IFormFile BookPdf { get; set; }

        public string BookPdfUrl { get; set; }

    }
}
