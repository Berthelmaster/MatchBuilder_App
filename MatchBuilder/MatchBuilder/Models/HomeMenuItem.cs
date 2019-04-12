using System;
using System.Collections.Generic;
using System.Text;

namespace MatchBuilder.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        NewMatch,
        AddPlayers,
        Contribute
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
