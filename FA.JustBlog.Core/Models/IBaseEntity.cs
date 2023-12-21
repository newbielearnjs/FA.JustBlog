﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models
{
    public interface IBaseEntity
    {
        int Id { get; set; }

        bool IsDeleted { get; set; }

        //DateTime InsertedAt { get; set; }

        //DateTime UpdatedAt { get; set; }
    }
}
