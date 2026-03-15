using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Models;
using InventoryManager.Data;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// 데이터 접근 담당
/// 데이터 가져오기
/// 데이터 저장하기
/// 파일 위치, JSON 구조 알 필요 없음 
/// </summary>
namespace InventoryManager.Services
{
    public class ProductRepository
    {
        private readonly JsonStorage storage;

        public ProductRepository()
        {
            storage = new JsonStorage();
        }

        // 제품 데이터 불러오기
        public List<Product> LoadProducts()
        {
            return storage.LoadFromFile();
        }

        // 제품 데이터 저장
        public void SaveProducts(List<Product> products)
        {
            storage.SaveToFile(products);
        }
    }
}
