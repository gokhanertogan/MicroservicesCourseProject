using Course.Shared.Dtos;
using CourseServices.Basket.Dtos;
using System.Threading.Tasks;

namespace CourseServices.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string userId);
    }
}
