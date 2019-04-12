using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using memberEAD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace memberEAD.Pages
{
    public class DeleteMembersModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        [TempData]
        public string Message2 { get; set; }

        private readonly MemberContext _db;

        public DeleteMembersModel(MemberContext db)
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

            var member = await _db.Members.FindAsync(Member.MemberID);

            if (member != null)
            {
                _db.Members.Remove(member);
                await _db.SaveChangesAsync();
            }

            Message = $"Student {member.MemberID} has been deleted";

            Message2 = $"Student {member.MemberID} has been deleted: Message2";

            return RedirectToPage("MemberDB",new { id = Member.MemberID });
        }
    }
}