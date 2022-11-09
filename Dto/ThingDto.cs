using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Dto
{
    public class ThingDto : GenericDto
    {

        public string Description { get; set; }
        public Category Category { get; set; }

    }
}
