﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BetterCms.Core.Models;
using BetterCms.Module.Root.Models;

namespace BetterCms.Module.Blog.ViewModels.Blog
{
    public class BlogPostViewModel
    {
        /// <summary>
        /// Gets or sets the blog id.
        /// </summary>
        /// <value>
        /// The blog id.
        /// </value>
        [Required]
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the entity version.
        /// </summary>
        /// <value>
        /// The entity version.
        /// </value>
        [Required]
        public virtual int Version { get; set; }

        /// <summary>
        /// Gets or sets the blog title.
        /// </summary>
        /// <value>
        /// The blog title.
        /// </value>
        [Required]
        [StringLength(MaxLength.Name)]
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets the blog intro text.
        /// </summary>
        /// <value>
        /// The blog intro text.
        /// </value>
        [StringLength(MaxLength.Text)]
        public virtual string IntroText { get; set; }

        /// <summary>
        /// Gets or sets the blog content.
        /// </summary>
        /// <value>
        /// The blog content.
        /// </value>
        [Required]
        public virtual string Content { get; set; }

        /// <summary>
        /// Gets or sets the live from date.
        /// </summary>
        /// <value>
        /// The live from date.
        /// </value>
        public virtual DateTime LiveFromDate { get; set; }

        /// <summary>
        /// Gets or sets the live to date.
        /// </summary>
        /// <value>
        /// The live to date.
        /// </value>
        public virtual DateTime LiveToDate { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        [Required]
        public virtual Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the cathegory.
        /// </summary>
        /// <value>
        /// The cathegory.
        /// </value>
        [Required]
        public virtual Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the post tags.
        /// </summary>
        /// <value>
        /// The post tags.
        /// </value>
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the list of authors.
        /// </summary>
        /// <value>
        /// The list of authors.
        /// </value>
        public IEnumerable<LookupKeyValue> Authors { get; set; }
        
        /// <summary>
        /// Gets or sets the list of categories.
        /// </summary>
        /// <value>
        /// The list of categories.
        /// </value>
        public IEnumerable<LookupKeyValue> Categories { get; set; }
    }
}