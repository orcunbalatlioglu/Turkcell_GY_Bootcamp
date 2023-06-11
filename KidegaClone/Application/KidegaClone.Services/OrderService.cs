using KidegaClone.DomainService.Repositories;
using AutoMapper;
using KidegaClone.Domain.DTOs.Request;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;

namespace KidegaClone.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public void Create(CreateNewOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _orderRepository.Create(order);
        }

        public int CreateAndReturnId(CreateNewOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _orderRepository.Create(order);
            return order.Id;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            await _orderRepository.CreateAsync(order);
            return order.Id;
        }

        public async Task CreateAsync(CreateNewOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            await _orderRepository.CreateAsync(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public IEnumerable<DisplayOrderResponse> GetAll()
        {
            var orders = _orderRepository.GetAll();
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public async Task<IEnumerable<DisplayOrderResponse>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public IEnumerable<DisplayOrderResponse> GetByAddressId(int addressId)
        {
            var orders = _orderRepository.GetByAddressID(addressId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public async Task<IEnumerable<DisplayOrderResponse>> GetByAddressIdAsync(int addressId)
        {
            var orders = await _orderRepository.GetByAddressIDAsync(addressId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public IEnumerable<DisplayOrderResponse> GetByBookId(int bookId)
        {
            var orders = _orderRepository.GetByBookId(bookId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public async Task<IEnumerable<DisplayOrderResponse>> GetByBookIdAsync(int bookId)
        {
            var orders = await _orderRepository.GetByBookIdAsync(bookId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public DisplayOrderResponse GetById(int id)
        {
            var order = _orderRepository.Get(id);
            var orderDisplay = _mapper.Map<DisplayOrderResponse>(order);
            return orderDisplay;
        }

        public async Task<DisplayOrderResponse> GetByIdAsync(int id)
        {
            var order = await _orderRepository.GetAsync(id);
            var orderDisplay = _mapper.Map<DisplayOrderResponse>(order);
            return orderDisplay;
        }

        public IEnumerable<DisplayOrderResponse> GetByUserId(int userId)
        {
            var orders = _orderRepository.GetByUserID(userId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public async Task<IEnumerable<DisplayOrderResponse>> GetByUserIdAsync(int userId)
        {
            var orders = await _orderRepository.GetByUserIDAsync(userId);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public UpdateOrderRequest GetForUpdate(int id)
        {
            var order = _orderRepository.Get(id);
            var orderUpdateRequest = _mapper.Map<UpdateOrderRequest>(order);
            return orderUpdateRequest;
        }

        public async Task<UpdateOrderRequest> GetForUpdateAsync(int id)
        {
            var order = await _orderRepository.GetAsync(id);
            var orderUpdateRequest = _mapper.Map<UpdateOrderRequest>(order);
            return orderUpdateRequest;
        }

        public IEnumerable<DisplayOrderResponse> GetSuccesfullOrUnsuccesfullPaid(bool isSuccesfull)
        {
            var orders = _orderRepository.GetBySuccessfullyPaid(isSuccesfull);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public async Task<IEnumerable<DisplayOrderResponse>> GetSuccesfullOrUnsuccesfullPaidAsync(bool isSuccesfull)
        {
            var orders = await _orderRepository.GetBySuccessfullyPaidAsync(isSuccesfull);
            var orderDisplays = _mapper.Map<IEnumerable<DisplayOrderResponse>>(orders);
            return orderDisplays;
        }

        public bool IsExist(int id)
        {
            return _orderRepository.IsExist(id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await _orderRepository.IsExistsAsync(id);
        }

        public void Update(UpdateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _orderRepository.Update(order);
        }

        public async Task UpdateAsync(UpdateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            await _orderRepository.UpdateAsync(order);
        }
    }

}
