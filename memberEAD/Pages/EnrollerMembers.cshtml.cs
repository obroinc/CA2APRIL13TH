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
    public class EnrollerMembersModel : PageModel
    {

/*
        private readonly MemberContext _db;



        //Data is stored on database

        public EnrollerMembersModel(MemberContext db)
        {
            _db = db;
        }


        public IList<Member> Member { get; private set; }

        public async Task OnGetAsync()
        {
            Member = await _db.Members.AsNoTracking().ToListAsync();
        }
*/




        
        public Member Member { get; set; } = new Member();


        private readonly MemberContext _db;

        

        //Data is stored on database

        public EnrollerMembersModel(MemberContext db)
        {
            _db = db;
        }

               

        public async Task <IActionResult> OnGetAsync(int id)
        {
            Member = await _db.Members.FindAsync(id);//locate id in db
            return Page();

        }
        


    }
}