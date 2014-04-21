Feature: First View 
  Scenario: As a user I want to see editText have expected default text 
  	Then I should see "Hello MvvmCross"
  	Then take picture

Scenario: As a user I want to set textView have expected default text 
    Then(/^I set the input to "([^\"]*)" on field with id "([^\"]*)" to "(.*?)"$/) do |"Updated Text", editText|
	
	Then I should see "Updated Text"
  	Then take picture
	