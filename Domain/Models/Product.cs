namespace Domain.Models
{
    /// <summary>
    /// The Prodcut Class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public Decimal Price { get; set; }

        /// <summary>
        /// Number of product in stock
        /// </summary>
        public int Stock { get; set; }
    }
}
