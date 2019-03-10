using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using DapperExtensions.Mapper;

namespace BillingSoftwareBLL.DAPPER
{
    class loginClassMapper: ClassMapper<loginClass>
    {
        public loginClassMapper()
        {
            base.Table("login");
            
            Map(a => a.username).Column("username");
            Map(a => a.password).Column("password");
          //  Map(a => a.id).Column("id").Key(KeyType.Assigned);
        }
    }
    class productDapperMapper: ClassMapper<productDapper>
    {
        public productDapperMapper()
        {
            base.Table("product");

            //  Map(a => a.username).Column("username");
            Map(a => a.id).Column("id");
            Map(a => a.item).Column("item");
            Map(a => a.cost).Column("cost");
           
        }
    }

    class insertsMapper: ClassMapper<inserts>
    {
        public insertsMapper()
        {
            base.Table("product");
            //  Map(a => a.username).Column("username");
            Map(a => a.id).Column("id").Key(KeyType.Assigned);
            Map(a => a.item).Column("item");
            Map(a => a.cost).Column("cost");
           
        }
        
    }
}
