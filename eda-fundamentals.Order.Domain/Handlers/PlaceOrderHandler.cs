using eda_fundamentals.Order.Domain.Commands;
using eda_fundamentals.Order.Domain.Events;
using eda_fundamentals.Order.Domain.EventServices;
using eda_fundamentals.Order.Domain.Repositories;
using eda_fundamentals.Shared.Commands.Handlers;

namespace eda_fundamentals.Order.Domain.Handlers
{
    public class PlaceOrderHandler : ICommandHandler<PlaceOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderEventService _orderEventService;
        public PlaceOrderHandler(
            IOrderRepository orderRepository,
            IUserRepository userRepository,
            IProductRepository productRepository,
            IOrderEventService orderEventService)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
            _orderEventService = orderEventService;
        }

        public async Task HandleAsync(PlaceOrderCommand command)
        {
            #region Criação das entidades
            var user = await _userRepository.GetByIdAsync(command.User);
            if (user == null)
                throw new Exception("Usuário não encontrado");

            var order = new Entities.Order(user);

            command.Items.ToList().ForEach(async x =>
                {
                    var product = await _productRepository.GetByIdAsync(x.Product);
                    if (product == null)
                        throw new Exception("Produto não encontrado");

                    order.AddItem(product, x.Quantity);
                });
            #endregion

            await _orderRepository.CreateAsync(order);

            order.OnOrderPlaced += OnOrderPlaced;

            order.Place();
        }

        private void OnOrderPlaced(object sender, EventArgs e) => _orderEventService.QueueAsync(new OrderPlacedEvent((Entities.Order)sender));
    }
}
