using System;

namespace aam_bonmark_user.Domain
{
    public class User
    {
        public int Id {get; set;}
        public String Fullname {get; set;}

        public User(String fullname){
            this.Fullname = fullname;
        }
    }
}
