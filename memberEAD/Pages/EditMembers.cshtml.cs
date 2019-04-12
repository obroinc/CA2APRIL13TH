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
    public class EditMembersModel : PageModel
    {




        private readonly MemberContext _db;

        public EditMembersModel(MemberContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Member = await _db.Members.FindAsync(id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Member).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception($"Student {Member.MemberID} not found!");
            }

            return RedirectToPage("/MemberDB");
        }
    }
}