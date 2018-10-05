using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IUBAT13wfa.DAL
{

    class Sale:Base
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime DateTime { get; set; }

        public int CustomerId { get; set; }

        public double Total { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder("insert into sale(number,dateTime,customerId, total) values(@number,@dateTime,@customerId, @total) select @@identity");
            Command.Parameters.AddWithValue("@number", Number);
            Command.Parameters.AddWithValue("@dateTime", DateTime);
            Command.Parameters.AddWithValue("@customerId", CustomerId);
            Command.Parameters.AddWithValue("@total", Total);

            if (!Connection())
                return false;

            try
            {
                Id = Convert.ToInt32(Command.ExecuteScalar());
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
            return false;
        }

        public bool Update()
        {
            Command = CommandBuilder("update sale set number= @number,dateTime=@dateTime,customerId=@customerId, total=@total where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@number", Number);
            Command.Parameters.AddWithValue("@dateTime", DateTime);
            Command.Parameters.AddWithValue("@customerId", CustomerId);
            Command.Parameters.AddWithValue("@total", Total);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from sale where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select id, number,dateTime,customerId, total from sale where id = @id");
            Command.Parameters.AddWithValue("@id", Id);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                Number = Reader["number"].ToString();
                DateTime = (DateTime)Reader["dateTime"];
                CustomerId = (int)Reader["customerId"];
                Total = (double)Reader["total"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select s.id,s.number,c.name, s.total from sale as s leftjoin customer as c where s.customerId= c.id");
            return ExecuteDataSet(Command);
        }

    }
}
