using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villas = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Villa 1" },
            new VillaDTO { Id = 2, Name = "Villa 2" },
        };
    }
}
