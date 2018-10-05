using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class Product:Base
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public int brandid { get; set; }
        public int unitid { get; set; }
        public int categoryid { get; set; }
        public byte[] image { get; set; }
        public DateTime date { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into product(name, code,description,price,discount,brandid,unitid,categoryid,image,date) values(@name, @code,@description,@price,@discount,@brandid,@unitid,@categoryid,@image,@date)");
            Command.Parameters.AddWithValue("@name", name);
            Command.Parameters.AddWithValue("@code", code);
            Command.Parameters.AddWithValue("@description", description);
            Command.Parameters.AddWithValue("@price", price);
            Command.Parameters.AddWithValue("@discount", discount);
            Command.Parameters.AddWithValue("@brandid",brandid);
            Command.Parameters.AddWithValue("@unitid", unitid);
            Command.Parameters.AddWithValue("@categoryid", categoryid);
            Command.Parameters.AddWithValue("@image", image);
            Command.Parameters.AddWithValue("@date", date);

            return Execute(Command);


        }


        public bool Update()
        {
            Command = CommandBuilder("update product set name = @name,code=@code where id = @id");
            Command.Parameters.AddWithValue("@id", id);
            Command.Parameters.AddWithValue("@name", name);
            Command.Parameters.AddWithValue("@code", code);
            Command.Parameters.AddWithValue("@description", description);
            Command.Parameters.AddWithValue("@price", price);
            Command.Parameters.AddWithValue("@discount", discount);
            Command.Parameters.AddWithValue("@brandid", brandid);
            Command.Parameters.AddWithValue("@unitid", unitid);
            Command.Parameters.AddWithValue("@categoryid", categoryid);
            Command.Parameters.AddWithValue("@image", image);
            Command.Parameters.AddWithValue("@date", date);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from country where id = @id");
            Command.Parameters.AddWithValue("@id", id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, name, code, description, price, discount, unitid, brandId, categoryId, image, date from product where id = @id");
            Command.Parameters.AddWithValue("@id", id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                name = Reader["name"].ToString();
                code = Reader["code"].ToString();
                description = Reader["description"].ToString();
                price = (double)Reader["price"];
                discount = (double)Reader["discount"];
                unitid = (int)Reader["unitId"];
                brandid = (int)Reader["brandId"];
                categoryid = (int)Reader["categoryId"];
                image = (byte[])Reader["image"];
                date = (DateTime)Reader["date"];
                return true;
            }
            return false;
        }
        public DataSet Select()
        {
            Command = CommandBuilder("select p.id, p.name, p.code, p.description, p.price, p.discount, u.name as unit, b.name as brand, c.name as category, p.image, p.Date from product as p left join unit as u on p.unitId= u.id left join brand as b on p.brandId= b.id left join category as c on p.categoryId= c.id ");
            return ExecuteDataSet(Command);
        }




    }
}
