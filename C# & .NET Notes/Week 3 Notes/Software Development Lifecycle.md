# Software Development Lifecycle (SDLC)
* A process use to design, develop and test high quality softwares
* Describes how a certain software was developed
* Planning -> Defining -> Designing -> Building -> Testing -> Deployment
## Big Bang Model
* 3 phases: Design? Build!!!! Test?
* Good for prototypes, learning new languages, and implementing some new feature without integrating it into the application
## Waterfall Model
* Rigid
* Requirements -> Design -> Implementation -> Verification -> Maintenance
* Highly documented
* You go through each phase once
* Good for projects that require on-time delivery like software for rockets, or military projects
## V-Model
* AKA Verification and Validation model
* Requirement Analysis -> System Design -> Architecture Design -> Module Design -> **Coding** -> Unit Testing -> Integration Testing -> System Testing -> Acceptance Testing
* An extension of the waterfall model, is based on the assocation of a testing phase for each corresponding development stage
* The Corresponding testing phase of the development phase is planned in parallel
## Agile (https://agilemanifesto.org/)
* Agile is more of a concept than an actual methodology unlike the first two models
* About being able to develop and deploy software quickly by not wasting time discussing design and planning
* It's about communicating consistently with the stakeholders and client about what they would want in the project and making plans on applying their requests in an iterative way to the current development wouldn't be disturbed
## Scrum
* Sprints: Sprint planning -> Daily scrum (huddle, progress update) -> Sprint Review -> Sprint Retro (plan for improvements)
* Backlogs
    * Contains the user stories(features) that need to be implemented
    * Each user story would have a point value for the amount of effort it would take to implement the user story
    * During sprint planning, you would assess which user stories to implement based on their urgency and match the total points against your capacity - the total amount of work hours you actually have
* Project/Scrum Board and Burndown Chart
    * Board and Chart maintained by scrum master to keep track of the project during development
    * Columns of the Board
        * Story (feature)
        * To Do
        * In Progress
        * To Verify
        * Done 
    * Burndown Chart
        * Tracks sprint velocity in a downwards graph that describes the total amount of points finished during a sprint.
## YOLO Development
* Similar to Big Bang, except it makes it into production
* Only has one iteration like in waterfall
* Flexible to changing requirements like in agile
* All about taking requirements from client/manager and coming up with something to show on project presentation
* Most apps developed under YOLO development are released once, never updated