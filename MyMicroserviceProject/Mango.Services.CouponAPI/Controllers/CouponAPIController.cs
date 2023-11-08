using AutoMapper;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {

        private AppDbContext _dbContext;
        private ResponseDto _response;
        private IMapper _mapper;

        public CouponAPIController(AppDbContext dbContext,IMapper mapper)

        {
            _dbContext = dbContext;
            _mapper= mapper;
            _response = new ResponseDto();

        }


        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objlist = _dbContext.Coupones.ToList();
                //return objlist;
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objlist); // thi sline maps the coupon to copuon dto by conversion of it rather than wrting the bunch of code this is the best practices to use it 
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;

            }
            return _response;
        }



        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Coupon objid = _dbContext.Coupones.First(u => u.CouponId==id);
               
                _response.Result = _mapper.Map<CouponDto>(objid);

            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
