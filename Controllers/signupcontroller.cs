using emergency.core;
using emergency.core.dto;
using emergency.repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace emergency.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class signupcontroller : ControllerBase
    {
        public readonly ISignup _signup;

        public signupcontroller(ISignup signup)
        {
            _signup = signup;
        }

        //[HttpGet]
        //public async Task<IActionResult> getallsignedu()
        //{
        //    var signup = await _context.signups.OrderBy(s => s.name).ToListAsync();
        //    return Ok(signup);

        //}
        [HttpPost]
        public async Task<IActionResult> writedatatosignup(signupDto dto)
        {
            var writedata = new signup {

                name = dto.name,
                e_mail = dto.e_mail,
                password = dto.password,
                phone_number = dto.phone_number
            };
            await _signup.writeuserdata(writedata);

            return Ok(writedata);
        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> updatedata(int id,signupDto dto)
        //{
        //    var data = await _context.signups.FindAsync(id);
        //    if (data == null)
        //        return BadRequest($"this id {id}is not found ");
        //    data.name = dto.name;
        //    data.password= dto.password;
        //    data.e_mail = dto.e_mail;
        //    data.phone_number = dto.phone_number;
        //    _context.SaveChanges();
        //    return Ok(data);
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> deletedata(int id)
        //{
        //    var finddata = await _context.signups.FindAsync(id);
        //    if (finddata == null)
        //        return BadRequest($"this is id {id}is not found");
        //    _context.Remove(finddata);
        //    _context.SaveChanges();
        //    return Ok(finddata);
        //}



    }
};
