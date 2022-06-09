using StarrySprouts.Data;

namespace StarrySprouts.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCartModel _shoppingCartModel;

        public OrderRepository(AppDbContext appDbContext, ShoppingCartModel shoppingCartModel)
        {
            _appDbContext = appDbContext;
            _shoppingCartModel = shoppingCartModel;
        }

        public void CreateOrder(OrderModel order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCartModel.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCartModel.GetAllShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetailsModel
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Product.Price,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = order.OrderId
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
