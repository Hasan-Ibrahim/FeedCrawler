﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedCrawler.Models
{
    public class RssFeed
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PublishedDate { get; set; }
    }
}