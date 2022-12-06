namespace Ymagazin.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int IDyslugi { get; set; }

        public int IDtipazakaza { get; set; }

        public int IDsotrudnika { get; set; }

        public int ClientId { get; set; }
        
        public Client Client { get; set; }
    }
}