using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bloggerweb.Models
{
    public class PostViewModel
    {
        [HiddenInput]
        public Int64 Id { get; set; }
        [Display(Name = "Post Content")]
        public string Content { get; set; }
    }
}
