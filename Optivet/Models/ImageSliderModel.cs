using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Optivet.Models
{
    public class ImageSliderModel
    {
        public List<Image> images { get; set; }

        public ImageSliderModel()
        {
            images = new List<Image>();
        }
    }

    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }
    }
}
