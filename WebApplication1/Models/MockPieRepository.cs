using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        public void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id=1,Name="Apple Pie",Price=12.9M,ShortDescription="Our famous apple pies!",LongDescription="Icing carrot cakes jello-o cheesecakes. Sweet roll marzin.",IsPieOfTheWeek=false},
                new Pie{Id=2,Name="Blueberry Cheese Cake",Price=18.9M,ShortDescription="You'll love it!",LongDescription="Icing carrot cakes jello-o cheesecakes. Sweet roll marzin.",IsPieOfTheWeek=false},
                new Pie{Id=3,Name="Cheese Cake",Price=17.9M,ShortDescription="Plain cheese cakes, plain pleasure.!",LongDescription="Icing carrot cakes jello-o cheesecakes. Sweet roll marzin.",IsPieOfTheWeek=true},
                new Pie{Id=4,Name="Cherry Pie",Price=13.9M,ShortDescription="A summer classic!",LongDescription="Icing carrot cakes jello-o cheesecakes. Sweet roll marzin.",IsPieOfTheWeek=false}
            };

        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
