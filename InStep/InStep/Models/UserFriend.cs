using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models
{
    public class UserFriend
    {
        [Key]
        public int Id { get; set; }

        public UserData UserId { get; set; }
        public UserData FriendId { get; set; }
    }
}