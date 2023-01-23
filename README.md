## 📒CSVDataSheetComparer
2개의 CSV 데이터 파일을 파싱하여 특정 어트리뷰트의 값을 비교 분석하는 프로그램

|사용 언어| 사용 프레임워크 |
|--------|-----|
|C#| Windows Form (.NET6) |

#
## 📒메인화면
<img src="https://user-images.githubusercontent.com/75249093/209571341-d59d9dd2-7f61-4e06-a4e3-dbc12b11157f.png" width="600" height="400"/>

 * Search 버튼 : 비교할 두개의 csv파일을 선택하는 버튼
 * Make Chart 버튼 : 로드된 두 csv파일의 y 축 데이터 속성이 선택된 경우 활성화,차트 생성
 
#
# 📒CSV로딩화면
<img src="https://user-images.githubusercontent.com/75249093/210582093-e29fa59e-b98f-4efb-a1c9-5de734144714.png" width="800" height="400"/>

<img src="https://user-images.githubusercontent.com/75249093/211336367-bc4131f3-13cf-42dc-9fdc-00e58bd899dd.png" width="600" height="400"/>

 * 상단에 불러온 두 csv파일의 파일명이 출력된다.
 * 불러온 데이터시트의 속성을 더블클릭하면 좌측의 y축 데이터 속성이 설정된다.

#
# 📒파라미터확인화면
<img src="https://user-images.githubusercontent.com/75249093/211336785-c789a83b-2c88-446d-953d-817f3c0b0f8c.png" width="600" height="400"/>

 * 두 데이터 시트 모두의 y축 속성이 선택되어 Make Chart 버튼이 활성화 된 상태에서 클릭 시, x축(행의 수)의 범위와, y축(열의 값)의 범위가 출력된다.
 * 이 때, Apply 버튼을 클릭하면 선택된 값을 기반으로 그래프가 그려진다.

#
# 📒차트출력화면
<img src="https://user-images.githubusercontent.com/75249093/211337352-c2ab785b-4a97-4428-9b68-52131fc4c091.png" width="600" height="400"/>


#
