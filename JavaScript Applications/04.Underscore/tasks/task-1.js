
/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/

//var students = [{firstName:'boicho', lastName:'zov'},
//  {firstName:'abc', lastName:'zov'}]






function solve(){
 return function(students) {
   _.chain(students)
       .filter(function (student) {
         //console.log(student.firstName + ' ' + student.lastName);
          return student.firstName.toLowerCase() < student.lastName.toLowerCase();
       }).map(function(st) {
           st.fullname = st.firstName + ' ' + st.lastName;
          return st;
        }).sortBy('fullname')
        .reverse()
        .each(function(st) {
          console.log(st.fullname)
       })
      //console.log(students);
  };
}

//function solve(){
//  return function(students) {
//
//    var filteredStudents = _.filter(students, function (student) {
//      return student.firstName.toLowerCase() < student.lastName.toLowerCase();
//    })
//
//    var formattedStudents = _.map(filteredStudents,function(st) {
//      st.fullname = st.firstName + ' ' + st.lastName;
//      return st;
//    })
//
//    var sortedStudents =  formattedStudents.sort(function(st1, st2) {
//         if (st1.fullname > st2.fullname) {
//            return -1
//          } else {
//            return 1
//          }
//        })
//      _.each(sortedStudents,function(st) {
//          console.log(st.fullname)
//        })
//  };
//}

module.exports = solve;


//var result = filterStudents(students);
//console.log(result);
//console.log(result);

