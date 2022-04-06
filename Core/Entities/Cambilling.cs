namespace Core.Entities
{
    public class Cambilling
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public int BillingId { get; set; }  
        public Billing Billing { get; set; }  
        public int UserId { get; set; }  
        public User User { get; set; }  
        public int ForpostId { get; set; }  
        public Forpost Forpost { get; set; }  
    }        
}