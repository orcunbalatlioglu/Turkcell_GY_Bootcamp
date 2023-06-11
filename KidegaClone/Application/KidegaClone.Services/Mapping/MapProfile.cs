using KidegaClone.Domain.Entities;
using AutoMapper;
using KidegaClone.Domain.DTOs.Response;
using KidegaClone.Domain.DTOs.Request;
namespace KidegaClone.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Address
            CreateMap<Address, DisplayAddressResponse>();
            CreateMap<CreateNewAddressRequest, Address>();
            CreateMap<UpdateAddressRequest, Address>();

            //Author
            CreateMap<Author, DisplayAuthorResponse>();
            CreateMap<CreateNewAuthorRequest, Author>();
            CreateMap<UpdateAuthorRequest, Author>();

            //Book
            CreateMap<Book, DisplayBookResponse>();
            CreateMap<CreateNewBookRequest, Book>();
            CreateMap<UpdateBookRequest, Book>();

            //Category
            CreateMap<Category, DisplayCategoryResponse>();
            CreateMap<CreateNewCategoryRequest, Category>();
            CreateMap<UpdateCategoryRequest, Category>();

            //Order
            CreateMap<Order, DisplayOrderResponse>();
            CreateMap<CreateNewOrderRequest, Order>();
            CreateMap<UpdateOrderRequest, Order>();

            //Publisher
            CreateMap<Publisher, DisplayPublisherResponse>();
            CreateMap<CreateNewPublisherRequest, Publisher>();
            CreateMap<UpdatePublisherRequest, Publisher>();

            //Review
            CreateMap<Review, DisplayReviewResponse>();
            CreateMap<CreateNewReviewRequest, Review>();
            CreateMap<UpdateReviewRequest, Review>();

            //User
            CreateMap<User, DisplayUserResponse>();
            CreateMap<CreateNewUserRequest, User>();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
        }
    }
}
