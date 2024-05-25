﻿using Microsoft.AspNetCore.Mvc;
using BE.Models;
using Swp391.Service;

namespace Swp391.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessengerBoxController : ControllerBase
    {
        private readonly MessengerBoxService _messengerService = new MessengerBoxService();


        //phương thức này dùng để insert feedback vào trong database
        [HttpPost]
        public IActionResult CreateMessengerBox([FromBody] MessengerBox messengerBox)
        {
            if (messengerBox == null)
            {
                return BadRequest(new
                {
                    err = "Messenger box object is null"
                });
            }

            int size = _messengerService.getAllMess().Count;

            MessengerBox messenger = new MessengerBox
            {
                MessengerBoxId = size + 1,  // Increment ID properly
                Author = messengerBox.Author,
                MessengerDescription = messengerBox.MessengerDescription,
                CreateDate = messengerBox.CreateDate
            };

            _messengerService.PostMessUI(messenger);

            return Ok(new
            {
                mess = "add successfully",
                data = messenger
            });
        }
    }
}
