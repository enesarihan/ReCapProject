using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _brands = new List<Brand> { 
            new Brand{BrandId=1,BrandName="Ford"},
            new Brand{BrandId=2,BrandName="Audi"},
            new Brand{BrandId=3,BrandName="Mercedes"},
            new Brand{BrandId=4,BrandName="BMW"},
                       
            };
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="black"},
                new Color{ColorId=2,ColorName="white"},
                new Color{ColorId=3,ColorName="gray"},
                new Color{ColorId=4,ColorName="red"},
                new Color{ColorId=5,ColorName="blue"},
            };
            _cars = new List<Car> {

                new Car{BrandId=1,ColorId=1,Id=1,DailyPrice=2500,ModelYear=2013,Description="Ford Focus" },
                new Car{BrandId=1,ColorId=2,Id=2,DailyPrice=1500,ModelYear=2013,Description="Ford Fiesta" },
                new Car{BrandId=2,ColorId=3,Id=3,DailyPrice=4500,ModelYear=2013,Description="Audi a5" },
                new Car{BrandId=3,ColorId=4,Id=4,DailyPrice=5500,ModelYear=2013,Description="Mercedes Benz cls" },
                new Car{BrandId=2,ColorId=1,Id=5,DailyPrice=1200,ModelYear=2013,Description="Audi a3" },
                new Car{BrandId=4,ColorId=3,Id=6,DailyPrice=1300,ModelYear=2013,Description="Bmw m2" },
                new Car{BrandId=2,ColorId=4,Id=7,DailyPrice=1300,ModelYear=2013,Description="audi rs" },
                new Car{BrandId=3,ColorId=2,Id=8,DailyPrice=4200,ModelYear=2013,Description="Mercedes benz gwagon" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetbyID(int id)
        {
            
            return _cars.Where(c=>c.Id==id).ToList();
             
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            
        }
    }
}
