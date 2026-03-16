using InventoryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 비즈니스 로직 담당
/// 서비스에 들어 갈 목록 
/// 제품 목록 반환
/// 제품 추가
/// 제품 수정
/// 제품 삭제
/// 이름 검색
/// </summary>
namespace InventoryManager.Services
{
    public class ProductService
    {
        // 저장소
        private readonly ProductRepository repository; // 저장 담당
        private List<Product> products;  // 현재 제품 목록

        public ProductService()
        {
            // ProductRepository 객체 생성
            // Service는 Repository를 통해서만 데이터를 저장/로드하도록 설계
            repository = new ProductRepository();
            // 프로그램 시작 시 기존 데이터 로드
            // Repository → JsonStorage → JSON 파일
            products = repository.LoadProducts();

            if(products == null)
            {
                products = new List<Product>();
            }
        }

        // 현재 제품 목록 반환 메서드
        // UI에서 현재 제품 목록 가져옴
        public List<Product> GetAllProducts()
        {
            // products 리스트 자체를 반환
            // Service 내부 데이터이지만 조회는 가능하도록 제공
            return products;
        }

        // 현재 products 리스트를 JSON 저장
        // UI에 의한 추가/수정/삭제 변경된 데이터를 JSON 파일에 반영
        public void Save()
        {
            // Reporisitoy에 저장 요청
            // Service는 파일을 Reporisitory를 통해 저장
            repository.SaveProducts(products);
        }

        // 새 제품 ID 생성
        // 제품 추가 시 고유 ID를 자동으로 생성
        // 현재 제품 ID + 1
        public int GenerateNextId()
        {
            // 제품이 하나도 없는 상태면 추가하는 제품이 1
            if (products.Count == 0)
            {
                return 1;
            }

            // 제품의 가장 큰 ID가 있으면
            int maxId = products.Max(p => p.Id);
            // 다음 ID 반환 
            return maxId + 1;
        }
        
        // 새 제품을 등록하는 메서드
        // UI에서 "제품 추가" 버튼 눌렀을때 실제 데이터 생성
        public void AddProduct(string productType, string name, int quantity)
        {
            // 제품 종류, 이름, 수량이 존재해야함
            ValidateProduct(productType, name, quantity);

            // 새로운 제품 ID 생성
            int newId = GenerateNextId();

            // Product 객체 생성
            Product product = new Product
            {
                Id = newId,
                ProductType = productType,
                Name = name,
                Quantity = quantity
            };

            // 생성된 제품 목록 추가
            products.Add(product);
            
            // JSON 파일 저장
            Save();
        }

        // 제품 데이터 검증
        // 예외 방지
        private void ValidateProduct(string productType, string name, int quantity)
        {
            if(string.IsNullOrWhiteSpace(productType))
            {
                throw new Exception("제품의 종류를 입력하세요.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("제품의 이름을 입력하세요.");
            }

            if (quantity < 0)
            {
                throw new Exception("수량은 1개부터 가능합니다.");
            }
        }

        // 제품 정보 수정
        // 제품 이름,종류,수량 수정
        public void UpdateProduct(int id, string productType, string name, int quantity)
        {
            // 어떤 제품을 수정?
            // Id 기준 제품 리스트에서 제품 찾기
            Product product = products.FirstOrDefault(p => p.Id == id);

            // 제품이 존재하지않을때 
            if(product == null)
            {
                throw new Exception("수정가능한 제품을 찾을 수 없습니다.");
            }

            ValidateProduct(productType, name, quantity);

            // 기존 객체의 값을 수정하는 방식, 덮어씌우는거지 삭제했다가 생성하는 방식아님
            product.ProductType = productType;
            product.Name = name;
            product.Quantity = quantity;

            Save();
        }

        // 제품을 목록에서 제거하기 위해 유일한 ID로 접근 
        public void DeleteProduct(int id)
        {
            // 1️⃣ 삭제할 제품 찾기
            // ID 기준으로 products 리스트에서 제품 검색
            Product product = products.FirstOrDefault(p => p.Id == id);

            // 제품이 없는 경우 예외 처리
            if (product == null)
            {
                throw new Exception("삭제할 제품을 찾을 수 없습니다.");
            }

            // 현재 메모리 목록에서 제품 삭제
            products.Remove(product);
            
            Save();
        }

        // 특정 제품 이름이나 종류를 기준으로 제품을 찾기 위해

        public List<Product> SearchProducts(string keyword)
        {
            // 검색어가 비어있으면 전체 반환
            // UI에서 검색어 없이 검색 버튼을 누르는 경우 대비
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return products;
            }

            // 검색 실행 
            // 제품 종류 또는 이름에 keyword가 포함된 제품 찾기
            string search = keyword.ToLower();

            var result = products.Where(p =>
                p.ProductType.ToLower().Contains(search) ||
                p.Name.ToLower().Contains(search)).ToList();

            return result;
        }
        
        // 재고 수량 증가
        public void IncreaseStock(int id, int amount)
        {
            // 증가수량 1 이상
            if(amount <= 0)
            {
                throw new Exception("증가 수량은 1 이상이어야 합니다.");
            }

            // Id 기준으로 증가 제품 찾기
            Product product = products.FirstOrDefault(p => p.Id == id);

            // 제품 없으면
            if(product == null)
            {
                throw new Exception("증가시킬 제품을 찾을 수 없습니다.");
            }

            // 제품 기존 수량 + 증가량
            product.Quantity += amount;

            Save();
        }

        // 재고 수량 감소
        public void DecreaseStock(int id, int amount)
        {
            if(amount <=0)
            {
                throw new Exception("감소 수량은 1 이상이어야 합니다");
            }

            Product product = products.FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                throw new Exception("감소시킬 제품을 찾을 수 없습니다.");
            }

            if(product.Quantity < amount)
            {
                throw new Exception("재고가 부족합니다.");
            }

            product.Quantity -= amount;

            Save();
        }

        // 재고 부족 제품 조회
        // threshold 이하인 제품만 반환
        public List<Product> GetLowStockProducts(int threshold)
        {
            if (threshold < 0)
            {
                throw new Exception("재고 기준값은 0 이상이어야 합니다.");
            }

            return products
                .Where(p => p.Quantity <= threshold)   // 재고 부족 필터
                .OrderBy(p => p.Quantity)              // 수량 오름차순 정렬
                .ToList();
        }

        // 이름순 정렬
        public List<Product> GetProductsSortedByName()
        {
            return products
                .OrderBy(p => p.Name)
                .ToList();
        }

        // 정렬 기준 : 제품 수량
        public List<Product> GetProductsSortedByQuantity()
        {
            // 제품 있으면 이름 기준으로 정렬
            return products
                .OrderBy(p => p.Quantity)
                .ToList();
        }

        // 정렬 기준 : 제품 수량 역순
        public List<Product> GetProductsSortedByQuantityDesc()
        {
            return products
                .OrderByDescending(p => p.Quantity)
                .ToList();
        }

        // 품절
        public List<Product> GetOutOfStockProducts()
        {
            return products
                .Where(p => p.Quantity <= 0)
                .ToList();
        }
    }
}
