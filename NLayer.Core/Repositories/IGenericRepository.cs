using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{ //ıgenericrepository = interface (CRUD Operasyonlarını burada yapacağız(create update dleete getbyId ))
    public interface IGenericRepository<T> where T : class     //T isminde bir class aldı Interface
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();                 //IQueryable ile datalar direk veri tabanına gitmez lotilst gibi metotların çağırılmasını bekler
                                                //Performans arttırma amaçlanır. 
                                                //productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //asenkron metotları memoryde az yer kaplasın dşye yapıyoruz
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);  //** interface implement ettik
        void Update(T entity); //asenkron metotları yoktur çünkü memoryde hızlı yapılır
        void Remove(T entity); //asenkron metotları yoktur çünkü memoryde hızlı yapılır
        void RemoveRange(IEnumerable<T> entities);


    }
}
