using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int Id);
        IDataResult<Color> GetByName(string Name);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
