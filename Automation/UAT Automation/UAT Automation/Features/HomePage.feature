Feature: Navigate Valtech WebSite

Scenario: As a User I want to see the Latest News section on the homepage
Given I am on the valtech homepage
Then the latest news page is displayed on the HomePage

Scenario Outline: As a User I want to make sure the pages are displaying the correct page name
Given I am on the <menupage> page
Then the <pagename> page is displayed
Examples:
| menupage | pagename |
| About    | About    |
| Services | Services |
| Work     | Work     |


