using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazingPizza.Client;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace BlazingPizza
{
    public sealed class MissingAccessTokenPizzaApi : IOrdersClient
    {
        private readonly AccessTokenNotAvailableException accessTokenNotAvailableException;

        public MissingAccessTokenPizzaApi(NavigationManager navigationManager)
        {
            accessTokenNotAvailableException = new AccessTokenNotAvailableException(
                navigationManager,
                new AccessTokenResult(
                    AccessTokenResultStatus.RequiresRedirect,
                    new AccessToken(),
                    "authentication/login"),
                Array.Empty<string>());
        }

        public Task<OrderWithStatus> GetOrder(int orderId)
        {
            throw accessTokenNotAvailableException;
        }

        public Task<IEnumerable<OrderWithStatus>> GetOrders()
        {
            throw accessTokenNotAvailableException;
        }

        public IAsyncEnumerable<OrderWithStatus> GetOrderUpdatesById(int orderId, CancellationToken cancellationToken = default)
        {
            throw accessTokenNotAvailableException;
        }

        public Task<IReadOnlyList<PizzaSpecial>> GetPizzaSpecials()
        {
            throw accessTokenNotAvailableException;
        }

        public Task<IReadOnlyList<Topping>> GetToppings()
        {
            throw accessTokenNotAvailableException;
        }

        public Task<int> PlaceOrder(Order order)
        {
            throw accessTokenNotAvailableException;
        }

        public Task SubscribeToNotifications(NotificationSubscription subscription)
        {
            throw accessTokenNotAvailableException;
        }
    }
}
