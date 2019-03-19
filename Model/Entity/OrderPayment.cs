namespace Model.Entity
{
    public class OrderPayment : EntityBase
    {
        public int OrderID { get; set; }
        public _OrderType OrderType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }



    }

    public enum _OrderType
    {
        Havale=0,
        KrediKarti=1
    }
}
