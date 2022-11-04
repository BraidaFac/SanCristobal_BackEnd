namespace GSC_BackEnd_TP.Entities
{
    public  abstract class BaseEntity
    {   
        public virtual int Id { get; set; }
        public virtual string? Description { get; set; } 
    }
}
