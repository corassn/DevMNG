using DevMNG.Entities;
using DevMNG.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //get all users
        [HttpGet]
        public ActionResult<List<User>> Get() =>
            _userRepository.Get();

        //get user by ID
        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<User> Get(string id)
        {
            var user = _userRepository.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        //CREATE new user
        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _userRepository.Create(user);

            return CreatedAtRoute("GetUser", new { id = user.Id.ToString() }, user);
        }

        //UPDATE existing user
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, User userIn)
        {
            var user = _userRepository.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Update(id, userIn);

            return NoContent();
        }

        //DELETE user
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var user = _userRepository.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Remove(user.Id);

            return NoContent();
        }

    }
}
