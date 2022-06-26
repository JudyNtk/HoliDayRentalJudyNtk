using B = HoliDayRental.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = HoliDayRental.DAL.Entities;

namespace HoliDayRental.BLL.Handlers
{
    public static class Mapper
    {
        public static B.Membre ToBLL(this D.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre(
                entity.IdMembre,
                entity.IdBien,
                entity.DateDebEchange,
                entity.DateFinEchange,
                entity.Assurance,
                entity.Valide
                );
        }

        public static D.Membre ToDAL(this B.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre(
                entity.IdMembre,
                entity.IdBien,
                entity.DateDebEchange,
                entity.DateFinEchange,
                entity.Assurance,
                entity.Valide
                );
        }

    }
}
