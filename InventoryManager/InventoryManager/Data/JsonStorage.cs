using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Models;
using Newtonsoft.Json;

/// <summary>
/// 진짜 파일 처리 담당
/// 파일 읽기
/// 파일 쓰기
/// 파일 I/O 담당
/// </summary>
namespace InventoryManager.Data
{
    /// <summary>
    /// JSON 파일 저장 / 로드 담당 클래스
    /// Repository에서 호출하는 실제 파일 I/O 담당
    /// </summary>
    public  class JsonStorage
    {
        // 저장할 JSON 파일 경로
        private readonly string filePath = "data/products.json";

        /// <summary>
        /// JSON 파일에서 제품 목록 불러오기
        /// </summary>
        public List<Product> LoadFromFile()
        {
            // 파일이 없으면 빈 리스트 반환
            if (!File.Exists(filePath))
            {
                return new List<Product>();
            }

            // JSON 파일 읽기
            string json = File.ReadAllText(filePath);
            // JSON → Product 리스트 변환
            var products = JsonConvert.DeserializeObject<List<Product>>(json);

            // null 방지
            return products ?? new List<Product>();
        }

        /// <summary>
        /// 제품 목록을 JSON 파일로 저장
        /// </summary>
        public void SaveToFile(List<Product> products)
        {
            // List<Product> → JSON 문자열 변환
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            // data 폴더 확인
            string directory = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // JSON 파일로 저장
            File.WriteAllText(filePath, json);
        }
    }

}
