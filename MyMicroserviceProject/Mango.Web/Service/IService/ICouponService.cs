using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetAllCouponsByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponCode);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponCode);
        Task<ResponseDto?> DeleteCouponsAsync(int id);

    }
}
