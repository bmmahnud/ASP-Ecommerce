using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Customer:Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Contact { get; set; }
        public string Email { get; set; }

        public bool Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into customer(name, contact, email, gender, joinDate, address, cityId) values(@name, @contact, @email, @gender, @joinDate, @address, @cityId)");
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@contact", Contact);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@gender", Gender);
            Command.Parameters.AddWithValue("@joinDate", JoinDate);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@cityId", CityId);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update customer set name = @name, contact = @contact, email = @email, gender = @gender, joinDate = @joinDate, address = @address, cityId = @cityId where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@contact", Contact);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@gender", Gender);
            Command.Parameters.AddWithValue("@joinDate", JoinDate);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@cityId", CityId);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from customer where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name,  contact, email, gender, joinDate, address, cityId from customer where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while(Reader.Read())
            {
                Name = Reader["name"].ToString();
                Contact = Reader["contact"].ToString();
                Email = Reader["email"].ToString();
                Gender = (bool)Reader["gender"];
                JoinDate = (DateTime)Reader["joinDate"];
                Address = Reader["address"].ToString();
                CityId = (int)Reader["cityId"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder(@"select c.id, c.name, c.contact, c.email, 
                                    case c.gender
                                    when 0 then 'Male'
                                    when 1 then 'Female'
                                    end as gender,
                                    c.joinDate,
                                    c.address, ct.name as city, cn.name as country
                                    from customer as c
                                    left join city as ct on c.cityId = ct.id
                                    left join country as cn on ct.countryId = cn.id");
            return ExecuteDataSet(Command);
        }

    }
}
