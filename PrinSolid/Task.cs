using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinSolid
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
