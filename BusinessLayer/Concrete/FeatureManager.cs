using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _FeatureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _FeatureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _FeatureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _FeatureDal.Delete(t);
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _FeatureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _FeatureDal.Update(t);
        }
    }
}
