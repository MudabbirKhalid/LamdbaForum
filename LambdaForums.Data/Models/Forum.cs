﻿using System;
using System.Collections.Generic;

namespace LambdaForums.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public DateTime Created { get; set; }
        string ImageUrl { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
