using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public UserSkill(int idUSer, int idSkill)
        {
            IdUSer = idUSer;
            IdSkill = idSkill;
        }

        public int IdUSer { get; private set; }
        public int IdSkill { get; private set; }
    }
}
