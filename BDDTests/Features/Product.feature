Feature: Product

Allows us to manage Products in out DataBase

@tag1
Scenario: Get Products that have stock over zero
	Given Database contains products :
	| productId                            | name              | description                         | price | stock |
	| b06f886f-d6d6-4d6b-ae4c-66879e298673 | CoolProduct       | Coolest product ever created        | 9.99  | 1     |
	| f0d8cb44-17fa-410d-9eb9-c092ae8ecf32 | SecondCoolProduct | Second Coolest product ever created | 30    | 0     |
	| fad592d0-e1c4-4a87-81e0-e60839ca2665 | ThirdCoolProduct  | Third Coolest product ever created  | 2.3   | 4     |
	| c2ab5934-4e6a-453d-845b-2c3af481d7cd | ForthCoolProduct  | Forth Coolest product ever created  | 3.2   | 0     |
	When A call is made to '/ProductsWithStock'
	Then The Result Should be : 
	| productId                            | name              | description                         | price | stock |
	| b06f886f-d6d6-4d6b-ae4c-66879e298673 | CoolProduct       | Coolest product ever created        | 9.99  | 1     |
	| fad592d0-e1c4-4a87-81e0-e60839ca2665 | ThirdCoolProduct  | Third Coolest product ever created  | 2.3   | 4     |