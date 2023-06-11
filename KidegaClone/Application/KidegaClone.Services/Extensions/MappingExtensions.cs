using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.Entities;
using AutoMapper;

namespace KidegaClone.Services.Extensions
{
    //TODO: MappingExtensions kullanılıp kullanılmayacağına karar ver.
    public static class MappingExtensions
    {
        public static T ConvertToResponse<T>(this IEnumerable<Address> input,IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<Author> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }        

        public static T ConvertToResponse<T>(this IEnumerable<Book> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<Category> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<Order> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<Publisher> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<Review> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }

        public static T ConvertToResponse<T>(this IEnumerable<User> input, IMapper mapper)
        {
            return mapper.Map<T>(input);
        }
    }
}
