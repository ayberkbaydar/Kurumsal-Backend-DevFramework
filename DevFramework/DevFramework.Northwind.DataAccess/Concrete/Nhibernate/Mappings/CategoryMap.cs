using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.Nhibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");

            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryID");/*id olan pk alanı burada verdiğimiz için, aşağıda ayrıca bir mapping yapmaya ihtiyacımız olmuyor.*/

            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
