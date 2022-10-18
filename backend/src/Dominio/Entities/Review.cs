using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Review
    {
        public Review(Guid userId,  string comment, int stars)
        {
            UserId = userId;
            Comment = comment;
            Stars = stars;
        }

        public Guid UserId { get; private set; }
        public DateTime Date { get; private set; } = DateTime.Now;
        public string Comment { get; private set; }
        public int Stars { get; private set; }
    }
}
