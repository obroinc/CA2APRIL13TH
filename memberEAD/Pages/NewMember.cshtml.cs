using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using memberEAD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace memberEAD.Pages
{
    public class NewMemberModel : PageModel
    {

        

        private readonly MemberContext _db;

        public NewMemberModel(MemberContext db)
        {
            _db = db;
        }


        [BindProperty]
        public Member Member { get; set; } = new Member();

        public void OnGet()
        {
          

    }

        public async Task<ActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Members.Add(Member);
                await _db.SaveChangesAsync();
               // MessageCreche = $"Thank You,{.FirstName} {Student.LastName} application ahs been recorded, it costs €{Student.GetCost()}";//message that students has been added
                return RedirectToPage("./MemberDB", new { id = Member.MemberID });
            }
            else
            {
                return Page();
            }
        }//END OF OnPostAsync()





    }
}