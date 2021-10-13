using AspNetCore.Identity.MongoDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Entities
{
    public class Role: MongoIdentityRole<Guid>
    {
    }
}
