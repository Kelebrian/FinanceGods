using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class Player
    {
        public User User { get; set; }
        public PlayerState State { get; set; }
        public int PlayerNumber { get; set; }
        public Player() { }
        public Player(User user, PlayerState state, int number)
        {
            User = user;
            State = state;
            PlayerNumber = number;
        }
    }
}
