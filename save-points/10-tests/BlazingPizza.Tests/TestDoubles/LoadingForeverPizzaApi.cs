using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using BlazingPizza.Client;

namespace BlazingPizza
{
    public sealed class LoadingForeverPizzaApi : IOrdersClient, IDisposable
    {
        private readonly TaskCompletionSource loadTask = new TaskCompletionSource();

        public void Dispose()
        {
            loadTask.SetResult();
        }

        public async Task<OrderWithStatus> GetOrder(int orderId)
        {
            await loadTask.Task;
            return default!;
        }

        public async Task<IEnumerable<OrderWithStatus>> GetOrders()
        {
            await loadTask.Task;
            return Array.Empty<OrderWithStatus>();
        }

        public async IAsyncEnumerable<OrderWithStatus> GetOrderUpdatesById(int orderId, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await loadTask.Task;
            yield break;
        }

        public async Task<IEnumerable<PizzaSpecial>> GetPizzaSpecials()
        {
            await loadTask.Task;
            return Array.Empty<PizzaSpecial>();
        }

        public async Task<IEnumerable<Topping>> GetToppings()
        {
            await loadTask.Task;
            return Array.Empty<Topping>();
        }

        public async Task<int> PlaceOrder(Order order)
        {
            await loadTask.Task;
            return 0;
        }

        public async Task SubscribeToNotifications(NotificationSubscription subscription)
        {
            await loadTask.Task;
        }
    }
}
