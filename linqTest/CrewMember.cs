﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqTest
{
    class CrewMember
    {
        public string Fname {
            get;
            set;
        }
        public string Lname {
            get;
            set;
        }
        public string Position {
            get;
            set;
        }
        public string Rank {
            get;
            set;
        }

        public CrewMember(string fname = "none", string lname= "none", string position= "none", string rank= "none") {
            Fname = fname;
            Lname = lname;
            Position = position;
            Rank = rank;
        }
    }
}
