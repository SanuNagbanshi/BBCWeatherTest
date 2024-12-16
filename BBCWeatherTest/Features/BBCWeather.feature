Feature: BBCWeather

@mytag
Scenario: Validate Tomorrow's High Temperature is higher than Tomorrrow's Low Teperature on BBC Weather Page
	Given Url of BBC Weather Site is launched
	When I enter city Name as "BourneMouth"
	And I click on Tomorrow Date On Weather Page
	Then I verify tomorrow Max temperature is higher than tomorrows low temperature