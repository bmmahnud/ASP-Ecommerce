using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT13wfa.DAL
{
    class SaleDetails:Base
    {
        public int SaleId { get; set; }

        public int ProductId { get; set; }

        public double Rate { get; set; }

        public double Qty { get; set; }

        public double SubTotal
        {
            get
            {
                return Rate * Qty;
            }
        }

        public bool Insert()
        {
            Command = CommandBuilder("insert into saleDetails(saleId,productId,rate, qty) values(@saleId,@productId,@rate, @qty)");
            Command.Parameters.AddWithValue("@saleId", SaleId);
            Command.Parameters.AddWithValue("@productId",  ProductId);
            Command.Parameters.AddWithValue("@rate",  Rate);
            Command.Parameters.AddWithValue("@qty",  Qty);
            return Execute(Command);
        }

        public bool Update()
        {
            Command = CommandBuilder("update saleDetails set rate= @rate, qty= @qty where saleId = @saleId & productId=@productId");
            Command.Parameters.AddWithValue("@saleId", SaleId);
            Command.Parameters.AddWithValue("@productId", ProductId);
            Command.Parameters.AddWithValue("@rate", Rate);
            Command.Parameters.AddWithValue("@qty", Qty);
            return Execute(Command);
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from saleDetails where saleId = @saleId & productId= @productId");
            Command.Parameters.AddWithValue("@saleId", SaleId);
            Command.Parameters.AddWithValue("@productId", ProductId);
            return Execute(Command);
        }

        public bool SelectById()
        {
            Command = CommandBuilder("select saleId,productId,rate, qty from saleDetails where saleId = @saleId ");
            Command.Parameters.AddWithValue("@saleId", SaleId);
            Reader = ExecuteReader(Command);
            while (Reader.Read())
            {
                ProductId = (int)Reader["productId"];
                Rate = (double)Reader["rate"];
                Qty = (double)Reader["qty"];
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            Command = CommandBuilder("select s.saleId, p.name , s.rate, s.qty  from saleDetails as s left join product as p where s.productId= p.id  ");
            return ExecuteDataSet(Command);
        }

    }
}
