using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Country:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into country(name) values(@name)");
            Command.Parameters.AddWithValue("@name", Name);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update country set name = @name where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from country where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name from country where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, name from country");
            return ExecuteDataSet(Command);
        }

    }
}
