using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Reviews
{
    public class Review
    {
        public Review(string userId, string comment, int stars)
        {
            UserId = userId;
            Comment = comment;
            Stars = stars;
        }

        public string UserId { get; private set; }
        public DateTime Date { get; private set; } = DateTime.Now;
        public string Comment { get; private set; }
        public int Stars { get; private set; }
    }
}
