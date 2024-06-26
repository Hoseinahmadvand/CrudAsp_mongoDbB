﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mongo.Services;
using mongo.Models;

namespace AspProMongoDb.Web.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = _userService.GetAll();
        }
    }
}
