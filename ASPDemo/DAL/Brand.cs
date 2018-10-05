using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Brand:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Origin { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into brand (name, description, origin) values(@name, @description, @origin)");
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@origin", Origin);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update brand set name = @name, description = @description, origin = @origin where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@origin", Origin);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from brand where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name, description, origin from brand where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                Description = Reader["description"].ToString();
                Origin = Reader["origin"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, name, description, origin from brand ");
            return ExecuteDataSet(Command);
        }

    }
}
