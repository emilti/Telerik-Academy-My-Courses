using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicTacToe.Web.DataModels
{
    public class JoinGameModel
    {
        [Required]
        public string GameId { get; set; }       
    }
}