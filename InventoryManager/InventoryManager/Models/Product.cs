using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 데이터 구조 정의
/// </summary>
namespace InventoryManager.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string ProductType { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
        public object Type { get; internal set; }

        //internal void Add(Product product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
