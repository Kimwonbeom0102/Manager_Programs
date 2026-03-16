# C# Manager Programs

C#과 WinForms를 활용하여 제작한 **데이터 관리 프로그램 모음 프로젝트**입니다.  
파일 기반 데이터 관리와 기본적인 사용자 인터페이스를 통해  
CRUD(Create, Read, Update, Delete) 기능을 구현했습니다.

이 저장소에는 다음 두 가지 관리 프로그램이 포함되어 있습니다.

---

#  Inventory Manager

재고 데이터를 관리하기 위한 프로그램입니다.  
제품 등록, 수정, 검색 및 재고 부족 조회 기능을 제공합니다.

GitHub Repository

: https://github.com/Kimwonbeom0102/InventoryManager

## 주요 기능

- 제품 등록 / 수정 / 삭제
- 제품 검색 기능
- 재고 수량 관리
- 재고 부족 제품 조회
- JSON 파일 기반 데이터 저장

## 사용 기술

- C#
- .NET
- WinForms
- JSON 데이터 처리

---

#  Membership Manager

회원 정보를 관리하는 프로그램입니다.  
회원 등록, 로그인 기능 및 관리자 권한 구분 기능을 구현했습니다.

GitHub Repository

: https://github.com/Kimwonbeom0102/MemebershipManager

## 주요 기능

- 회원 등록 / 수정 / 삭제
- 로그인 시스템
- 관리자 / 일반 사용자 권한 구분
- SHA256 기반 비밀번호 해싱
- JSON 파일 기반 회원 데이터 관리

## 사용 기술

- C#
- .NET
- WinForms
- SHA256 암호화
- JSON 데이터 처리

---

```
#  프로젝트 구조

InventoryManager
│
├ InventoryManager
│ └ 재고 관리 프로그램
│
├ MembershipManager
│ └ 회원 관리 프로그램
│
└ README.md
```

