;namespace StrollerEcomus.DAL.DataContext.Entities
{
    public class WishListItem:TimeStample
    {
        public string AppUserId { get; set; } = null!;
        public int ProductId { get; set; }
    }
}
