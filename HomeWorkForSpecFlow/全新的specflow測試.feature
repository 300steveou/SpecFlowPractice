Feature: 全新的specflow測試
	Simple calculator for adding two numbers
#user story
@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	
#@test
#Scenario: 計算數字 80*8-60 =580
#	Given  第一個數字是80
#	And  第二個數字是8
#	And  第三個數字是60
#	When 三者數字計算   
#	Then 得出結果是580