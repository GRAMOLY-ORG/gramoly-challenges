﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iCTF_Shared_Resources.Models
{
    public class Challenge
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Attachments { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Flag { get; set; }
        public int Points { get; set; }
        public int State { get; set; }
        public string Writeup { get; set; }
        public string Image { get; set; }        
        public int Priority { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Solve> Solves { get; set; } = new List<Solve>();
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
