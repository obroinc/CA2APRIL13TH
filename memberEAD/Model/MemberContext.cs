﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace memberEAD.Model
{
    public class MemberContext:DbContext
    {

        public MemberContext(DbContextOptions<MemberContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }

    }
}
