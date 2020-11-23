using System;
using System.Collections.Generic;

namespace Lektion_07
{
    class Chat
    {
        private Contacts partner { get; set; }
        private List<Message> previouseMsg { get; set; }

        public Chat(Contacts Partner, List<Message> PreviouseMsg)
        {
            partner = Partner;
            previouseMsg = PreviouseMsg;
        }
    }
}
