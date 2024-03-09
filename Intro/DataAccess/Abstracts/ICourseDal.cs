using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts;

public interface ICourseDal //interface,şablon

{// ICourseDal'ı implemente eden sınıf bu metotları içermek zorunda 
    List<Course> GetAll();
    void Add(Course course);

}
