using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class City:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }


        public bool Insert()
        {
            Command = CommandBuilder("insert into city(name, countryId) values(@name, @countryId)");
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@countryId", CountryId);

            return Execute(Command);


        }

        public bool Update()
        {
            Command = CommandBuilder("update city set name = @name, countryId = @countryId where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@countryId", CountryId);

            return Execute(Command);

        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from city where id = @id");
            Command.Parameters.AddWithValue("@id", Id);

            return Execute(Command);


        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name, countryId from city where id = @id");
            Command.Parameters.AddWithValue("@id", Id);

            Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                CountryId = (int)Reader["countryId"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select ct.id, ct.name, cn.name as country from city as ct left join country as cn on ct.countryId = cn.id");

            if (Name != null && Name != "")
            {
                Command.CommandText += " where ct.name like @search";
                Command.Parameters.AddWithValue("@search", "%" + Name + "%");
            }

            return ExecuteDataSet(Command);
        }

    }
}
