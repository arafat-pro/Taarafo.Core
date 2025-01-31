﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using Taarafo.Core.Models.Comments;

namespace Taarafo.Core.Models.Posts
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid Author { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
