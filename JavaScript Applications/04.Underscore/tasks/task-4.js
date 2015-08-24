/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:

```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/



function solve(){
  return function Grouping(animals) {
      //_.chain(animals)
      var sortedResult = {};
      var result = _.groupBy(animals, 'species');
      function order(result)
      {
          return _.object(_.sortBy(_.pairs(result),function(o){
              return o[0]
          }).reverse());
      }

      sortedResult = order(result);
          _.each(sortedResult, function(value, key) {
            var len = key.length;
            var dashes =  Array(len + 2).join("-");
            console.log(dashes);
            //console.log(dashes + key + dashes);
            console.log(key + ':');
            console.log(dashes);
            var sortedCollection = _.chain(value).sortBy('name').sortBy('legsCount').value();
            _.each(sortedCollection, function(an){
                console.log(an.name + ' has ' + an.legsCount + ' legs');
            })
      });
  };
}

//var animals = [{
//    name: 'Minkov',
//    species: 'Mosquito',
//    legsCount: 2
//}, {
//    name: 'Doncho',
//    species: 'Mosquito',
//    legsCount: 2
//}, {
//    name: 'Komara',
//    species: 'Mosquito',
//    legsCount: 4
//}];
//
module.exports = solve;

//var result = Grouping(animals);


