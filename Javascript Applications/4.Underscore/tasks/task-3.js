/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
    var student = _.chain(students)
        .map(function(st) {
          var sumOfMarks = _.reduce(st.marks, function (memo, num) {
            return memo + num;
          })

          st.averageMark = sumOfMarks / st.marks.length;
          return st;
         }).sortBy(function(st){
           return st.averageMark;
        }).last().value();
    student.fullname = student.firstName + ' ' + student.lastName
    console.log(student.fullname + ' has an average score of ' + student.averageMark);
  };
}

module.exports = solve;
