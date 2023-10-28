using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    
    public class ProductsContoller : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductService _service;

        public ProductsContoller(IMapper mapper, IService<Product> service, IProductService productService)
        {
            _mapper = mapper;
            _service = productService;
        }



        //Get api/products/GetProdctsWithCategory
        
        
        [HttpGet("[action]")]                         //diğer get ler ile çakışmaması için direk action = GetProdctsWithCategory adress verdik
        public async Task<IActionResult> GetProdctsWithCategory()
        {
            return CreateActionResult(await _service.GetProductsWithCategory());
        }



        //Get api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products).ToList();
            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }



        //Get api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));
        } 
        
        
        
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDtos));
            //201 createdoluşturuldu anlamına geliyor işlem başarılı
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productDto)  //update de gereksiz crate date gibi dataları içermeyen update dto kullandık.
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


        //Get api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var products = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(products);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
