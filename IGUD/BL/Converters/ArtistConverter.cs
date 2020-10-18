using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
 public   class ArtistConverter
    {
        public static ArtistDTO ToDTO(Artist g)
        {
            return new ArtistDTO()
            {
                ArtistId = g.ArtistId,
                FirstName = g.FirstName,
                LastName = g.LastName,
                 Kind = g.Kind,
                 Phone=g.Phone,
                 eMail=g.eMail
    };
        }

        public static Artist FromDTO(ArtistDTO g)
        {
            return new Artist()
            {
                ArtistId = g.ArtistId,
                FirstName = g.FirstName,
                LastName = g.LastName,
                Kind = g.Kind,
                Phone=g.Phone,
                eMail=g.eMail
            };
        }
        public static List<ArtistDTO> GetListActivityDTO(List<Artist> lArtist)
        {
            List<ArtistDTO> l = new List<ArtistDTO>();
            lArtist.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<Artist> GetListActivityDAL(List<ArtistDTO> lArtist)
        {
            List<Artist> l = new List<Artist>();
            lArtist.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}

