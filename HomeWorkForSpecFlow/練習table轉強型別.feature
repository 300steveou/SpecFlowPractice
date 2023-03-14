Feature: 練習table轉強型別
	給予出單號碼,傳回出單狀態

@mytag
Scenario: 查詢訂單狀態
	Given 輸入出單號碼
	| ShippingNo |
	| F12345   |	 
 	And 已存在出單清單
 	| Id | ShippingNo | Status |
    | 1  | F12345     | 10      |
    | 2  | F12346     | 55      |
    | 3  | F12347     | 90      |
	When 按下送出
	Then 結果為10
	