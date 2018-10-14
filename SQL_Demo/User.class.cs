using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_Demo {
    //class User {

    //    private string name { get; set; }
    //    private string lastName { get; set; }
    //    private string password { get; set; }

    //    User(string name_c, string lastName_c, string password_c) {
    //        name = name_c;
    //        lastName = lastName_c;
    //        password = password_c;
    //    }
    //}

    interface User_Record {
        string name { get; set; }
        string lastName { get; set; }
        string password { get; set; }
    }
}
