using System;
using System.Collections.Generic;

namespace Lektion_07
{
    class Group : Chat
    {
        public List<Contacts> members { get; set; }

        public Group(List<Contacts> Members)
        {
            members = Members;
        }
    }
}
