using BL.Converters;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
 public   class ArtistBL
    {
        public static void Add(ArtistDTO item)
        {
            if(ArtistDAL.Get(item.ArtistId)==null)
            ArtistDAL.Add(ArtistConverter.FromDTO(item));
        }

        public static void Delete(int id)
        {
            ArtistDAL.Delete(id);
        }

        public static List<ArtistDTO> GetAll()
        {
            return ArtistConverter.GetListActivityDTO(ArtistDAL.Get());
        }

        public static ArtistDTO GetById(int id)
        {
            return ArtistConverter.ToDTO(ArtistDAL.Get(id));
        }

        public static void Update(ArtistDTO artist)
        {
            ArtistDAL.Put(ArtistConverter.FromDTO(artist));
        }
    }
}

