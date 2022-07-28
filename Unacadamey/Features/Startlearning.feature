	 Feature:Startlearning


	Scenario: [Verifying Unacademy Startlearning functionality on chrome]
	Given Chrome is launched and Unacademy application is launched
	When User clicks on Startlearning Button
	Then It shows Home Page


	
	Scenario: [Verifying Unacademy HealthandFitness functionality on chrome]
 	Given Chrome is launched and Unacademy application is launched
    When User clicks on Startlearning Button
	And User goto HealthandFitness and clicks on Yoga
	Then It shows Yoga page with Choose a batch button

		
	Scenario: [Verifying Unacademy JEEandNEETPreapration functionality on chrome]
	Given Chrome is launched and Unacademy application is launched
	When User clicks on Startlearning Button
	And User goto JEEandNEETPreparation and clicks on IIT JEE
    Then It shows IIT JEE page with get subscription button

		

	Scenario: [Verifying Unacademy Marketing functionality on chrome]
 	Given Chrome is launched and Unacademy application is launched
    When User clicks on Startlearning Button
	And User goto Marketing and clicks on Digital Marketing
	Then It shows Digital Marketing page with Choose a batch button

		 
	 Scenario:[Verifying Unacademy StatePSC functionality on chrome]
 	Given Chrome is launched and Unacademy application is launched
	When User clicks on Startlearning Button
	And User goto StatePSC and clicks on TNPSC
	Then It shows TNPSC page with Get a subscription button

	
