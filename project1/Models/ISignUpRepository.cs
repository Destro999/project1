using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public interface ISignUpRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
