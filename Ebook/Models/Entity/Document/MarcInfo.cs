﻿using System.Collections.Generic;

namespace Ebook.Models.Entity.Document
{
    public class MarcInfo
    {
        public string Title { get; set; }
        public DocumentInfo DocumentInfo { get; set; }
        public List<string> DocumentSummaryTitle { get; set; }
        public string Author { get; set; }

    }
}