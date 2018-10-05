using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Unit:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public int PrimaryQty { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into unit (name, description, primaryQty) values(@name, @description, @primaryQty)");
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@primaryQty", PrimaryQty);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update unit set name = @name, description = @description, primaryQty = @primaryQty where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@description", Description);
            Command.Parameters.AddWithValue("@primaryQty", PrimaryQty);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from unit where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name, description, primaryQty from unit where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                Description = Reader["description"].ToString();
                PrimaryQty = (int)Reader["primaryQty"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select id, name, description, primaryQty from unit ");
            return ExecuteDataSet(Command);
        }

    }
}
