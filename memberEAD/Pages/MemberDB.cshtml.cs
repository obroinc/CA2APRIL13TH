using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using memberEAD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace memberEAD.Pages
{
    public class MemberDBModel : PageModel
    {
       
        
            private readonly MemberContext _db;




            //Data is stored on database

            public MemberDBModel(MemberContext db)
            {
                _db = db;
            }

            public IList<Member> Members { get; private set; }

            public async Task OnGetAsync()
            {
                Members= await _db.Members.AsNoTracking().ToListAsync();

            }
        }
}