using DevMNG.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly UserRepository _userRepository;

        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //register

        //login
    }
}
