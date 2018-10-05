using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Category:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public int CategoryId { get; set; }

        public bool Insert()
        {
            if (CategoryId > 0)
            {
                Command = CommandBuilder("insert into category (name, description, categoryId) values(@name, @description, @categoryId)");
                Command.Parameters.AddWithValue("@categoryId", CategoryId);
            }
            else
            {
                Command = CommandBuilder("insert into category (name, description) values(@name, @description)");
            }
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update category set name = @name, description = @description, categoryId = @categoryId where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@categoryId", CategoryId);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from category where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name,  description from category where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                Description = Reader["description"].ToString();
                CategoryId = (int)Reader["categoryId"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select c.id, c.name, c.description, cat.name as category  from category as c left join category as cat on c.categoryId = cat.id ");
            return ExecuteDataSet(Command);
        }

    }
}
