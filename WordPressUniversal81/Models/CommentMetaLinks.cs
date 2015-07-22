﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressUniversal.Models
{
    /// <summary>
    /// contains links to get more meta information about the actual comment
    /// </summary>
    public class CommentMetaLinks
    {
        /// <summary>
        /// the API link to get actual comment
        /// </summary>
        [JsonProperty("self")]
        public string self { get; set; }

        /// <summary>
        /// the API link to the actual comment's help
        /// </summary>
        [JsonProperty("help")]
        public string help { get; set; }

        /// <summary>
        /// the API link to the actual comments's site
        /// </summary>
        [JsonProperty("site")]
        public string site { get; set; }

        /// <summary>
        /// the API link to the actual comment's parent post 
        /// </summary>
        [JsonProperty("post")]
        public string post { get; set; }

        /// <summary>
        /// the API link to the actual comments's replies
        /// </summary>
        [JsonProperty("replies")]
        public string replies { get; set; }

        /// <summary>
        /// the API link to the actual comments's likes
        /// </summary>
        [JsonProperty("likes")]
        public string likes { get; set; }

    }
}
