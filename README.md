# EducationLab

Assumptions:
* "The statement "student who has completed their assigned in class work" suggests that questions are part of a specific assignment that is sent to the user which has the questions that need answer.
* Assignment is created by a teacher or the system with a initial status and with a set of questions.
* Students might want to save their assignment without submitting. They might also choose to temporarily skip some questions if they aren't sure.
* Questions aren't submitted one by one. The student once confident with their answers will submit the assignment (submit all questions answers).
* Might also be possible to only see what questions the student answered correctly and the ones he/she hasn't answered yet (draft assignment).
* The API might be able to list topics and subtopics separately.
* The API might be able to list questions that belong to topics and subtopics (that are not associated to an assignment).
* The Question explanation and answer can only be fetched if the student has answered the question correctly as part of its active assignment.
* I think its also safe to assume each assignment will have less than 100 questions. (This assumption also drove the choice for the API designs)
* Safe to expect p75 of students to have less than 1/5 of wrong answers per assignment.
* Given the above assumptions its not expected that the request/response payloads to have a significate size.
* Although a design and flow was provided in this exercise, it is assumed that this is the design and flow of the "tutoring agency". It is also assumed that It's not the API responsibility to serve data to clients in the exact format they want to present it to their users. The API should be generic and intuitive to use by different users/clients and should return all necessary data to enabled the desired UI and flow.