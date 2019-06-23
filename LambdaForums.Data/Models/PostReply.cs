using System;

namespace LambdaForums.Data.Models
{
    public class PostReply
    {
        int Id { get; set; }
        string Content { get; set; }
        DateTime Created { get; set; }
        public virtual ApplicationUser User {get;set;}
        public virtual Post Post { get; set; }
    }
}
