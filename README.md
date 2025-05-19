# EducationLab

Assumptions:
* The statement 'student who has completed their assigned in-class work" suggests that questions are part of a specific assignment that is sent to the user, which has the questions that need to be answered. 
* An assignment is created by a teacher or the system with an initial status and a set of questions. 
* Students might want to save their assignment without submitting. They might also temporarily skip some questions if they aren't sure. 
* Questions aren't submitted one by one. The student, once confident with their answers, will submit the assignment (submit all question answers). 
* Might also be possible to see what questions the student answered correctly and the ones he/she hasn't answered yet (draft assignment). 
* The API might be able to list topics and subtopics separately. 
* The API might be able to list questions that belong to topics and subtopics (that are not associated with an assignment). 
* The Question explanation and answer can only be fetched if the student has answered the question correctly as part of their active assignment. 
* I think it's also safe to assume each assignment will have fewer than 100 questions. (This assumption also drove the choice for the API designs) 
* Safe to expect p75 of students to have fewer than 1/5 of wrong answers per assignment. 
* Given the above assumptions, it's not expected that the request/response payloads to have a significant size. 
* Although a design and flow were provided in this exercise, it is assumed that this is the design and flow of the "tutoring agency". It is also assumed that it's not the API's responsibility to serve data to clients in the exact format they want to present it to their users. The API should be generic and intuitive to be used by different users/clients and should return all necessary data to enable the desired UI and flow. 