﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetById(int id);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
