namespace BlazingPizza.Client
{
    public interface IOrdersClient
    {
        Task<OrderWithStatus> GetOrder(int orderId);
        Task<IEnumerable<OrderWithStatus>> GetOrders();
        Task<int> PlaceOrder(Order order);
        Task SubscribeToNotifications(NotificationSubscription subscription);
    }
}