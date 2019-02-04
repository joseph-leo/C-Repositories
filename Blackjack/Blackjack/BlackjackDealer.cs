﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackDealer : Dealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
    }
}
