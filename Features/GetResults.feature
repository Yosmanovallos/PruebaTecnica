Feature: GetResults

get the results  

@OpenGoogle
Scenario: Find the results of aid for aids
	Given Open the Browser
	When Enter to Google
	And Search for the Aid for Aids
	And Get all search results 
	And Validate how many belong to the domain
	And Validate that the search is greater than zero
	Then Finish the Test