# Test-driven Development [TDD] (code coverage, unit tests, mocking)
## Unit Testing
* Testing small units of your code
* Helpful when you wanna make sure everything is working perfectly (without repeating some actions to get there).
* Also helpful in pinpointing where the code is going wrong.
* The unit testing framework we'll be using is Xunit.
### Parts of a unit test
* Arrange
    * This is any set up necessary to prepare for the behavior to test. You assume the thing you wanna test works.
* Act
    * You do the thing you want to test. You usually name the method after the thing you want to test.
* Assert
    * Verify the behavior was as expected, sometimes on the same step as ACT.
## Test Driven Development
1. Write tests that fail
2. Implement code to make tests pass